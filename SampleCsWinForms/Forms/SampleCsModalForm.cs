using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;

namespace SampleCsWinForms.Forms
{
    public partial class SampleCsModalForm : Form
    {
    public SampleCsModalForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Hello button handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HelloButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Hello Rhino!", "SampleCsModalWinForm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    /// <summary>
    /// Pick button handler
    /// </summary>
    private void PickButton_Click(object sender, EventArgs e)
    {
      // Hide this form
      PushPickButton(true);

      // Pick something
      //Point3d pt0;
      
      //Rhino.Input.RhinoGet.GetPoint("Point", false, out pt0);
      
      // Show this form
      PushPickButton(false);
    }

    /// <summary>
    /// Hides this modal form so you can pick points or objects
    /// in a viewport. This is somewhat equivalent to the 
    /// CRhinoDialog::PushPickButton function found in the 
    /// Rhino C++ SDK.
    /// </summary>
    
    //AddLine
    RhinoDoc doc;
    public void button1_Click_1(object sender, EventArgs e)
    {
        PushPickButton(true);
        textBox1.Text = "Happy Hello World";
        //MessageBox.Show("Hello, world.");
        AddCircle(doc);
        //Rhino.RhinoApp.RunScript("_Box", false);
        PushPickButton(false);
    }
    
    //RhinoDoc doc;
    public static Rhino.Commands.Result AddCircle(Rhino.RhinoDoc doc)
    {
        Rhino.Geometry.Point3d center = new Rhino.Geometry.Point3d(0, 0, 0);
        const double radius = 10.0;
        Rhino.Geometry.Circle c = new Rhino.Geometry.Circle(center, radius);
        if (doc.Objects.AddCircle(c) != Guid.Empty)
        {
            doc.Views.Redraw();
            return Rhino.Commands.Result.Success;
        }
        return Rhino.Commands.Result.Failure;
    }
    private void PushPickButton(bool hideForm)
    {
      // Modal forms work by disabling the parent window. 
      // This is why you cannot click outside of a modal dialog.
      // PushPickButton works by re-enabling the parent window before
      // hiding the form. When the operation is finished, the parent
      // window is disabled (again) and the dialog displayed.

      IntPtr hwnd = RhinoApp.MainWindowHandle();

      if (hideForm)
      {
        bool enabled = IsWindowEnabled(hwnd);
        if (!enabled)
        {
          EnableWindow(hwnd, true);
          SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOMOVE);
        }

        Hide();
      }
      else
      {
        Show();
        Activate();

        RhinoApp.CommandPrompt = string.Empty;
        EnableWindow(hwnd, false);

        Enabled = true;
      }
    }
    


    #region Unmanaged Methods

    /// <summary>
    /// Determines whether the specified window is enabled for mouse and keyboard input.
    /// </summary>
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool IsWindowEnabled(IntPtr hWnd);

    /// <summary>
    /// Enables or disables mouse and keyboard input to the specified window or control. 
    /// When input is disabled, the window does not receive input such as mouse clicks 
    /// and key presses. When input is enabled, the window receives all input.
    /// </summary>
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

    [Flags]
    private enum SetWindowPosFlags : uint
    {
      SWP_NOMOVE = 0x0002,
      SWP_NOSIZE = 0x0001,
    }

    /// <summary>
    /// Changes the size, position, and Z order of a child, pop-up, or top-level window. 
    /// These windows are ordered according to their appearance on the screen. The 
    /// topmost window receives the highest rank and is the first window in the Z order.
    /// </summary>
    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

    #endregion


        
  }
}
