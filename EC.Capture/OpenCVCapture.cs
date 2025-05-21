using OpenCvSharp;

namespace EC.Capture;

internal class OpenCVCapture
{
    private readonly VideoCapture videoCapture = new();
    private Mat _frame = new();

    public OpenCVCapture(int idx)
    {
        var ok = videoCapture.Open(idx);
        if (ok)
        {
            // TODO
        }
    }

    public Mat GetFrame()
    {
        if (videoCapture.IsOpened())
        {
            videoCapture.Read(_frame);
            return _frame; // should check _frame.Empty()

            //using var m = videoCapture.RetrieveMat();
            //if (!m.Empty())
            //{
            //    m.ToBytes();
            //    string strbaser64 = Convert.ToBase64String(m.ToBytes());
            //}
        }
        
        return new Mat();
    }
}
