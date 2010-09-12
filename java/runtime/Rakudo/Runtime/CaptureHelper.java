package Rakudo.Runtime;

import java.util.HashMap;
import Rakudo.Metamodel.RakudoObject;
import Rakudo.Metamodel.Representations.P6capture;

/// <summary>
/// Provides helper methods for getting stuff into and out of captures,
/// both native ones and user-level ones.
/// </summary>
public class CaptureHelper
//public static class CaptureHelper
{
    /// <summary>
    /// Cache of the native capture type object.
    /// </summary>
    public static RakudoObject CaptureTypeObject;
//  internal static RakudoObject CaptureTypeObject;

    /// <summary>
    /// Empty capture former.
    /// </summary>
    /// <returns></returns>
    public static RakudoObject FormWith()
    {
        P6capture.Instance c = (P6capture.Instance)CaptureTypeObject.getSTable().REPR.instance_of(CaptureTypeObject);
        return c;
    }

    /// <summary>
    /// Forms a capture from the provided positional arguments.
    /// </summary>
    /// <param name="Args"></param>
    /// <returns></returns>
    public static RakudoObject FormWith(RakudoObject[] PosArgs)
    {
        P6capture.Instance C = (P6capture.Instance)CaptureTypeObject.getSTable().REPR.instance_of(CaptureTypeObject);
        C.Positionals = PosArgs;
        return C;
    }

    /// <summary>
    /// Forms a capture from the provided positional and named arguments.
    /// </summary>
    /// <param name="Args"></param>
    /// <returns></returns>
    public static RakudoObject FormWith(RakudoObject[] PosArgs, HashMap<String, RakudoObject> NamedArgs)
    {
        P6capture.Instance C = (P6capture.Instance)CaptureTypeObject.getSTable().REPR.instance_of(CaptureTypeObject);
        C.Positionals = PosArgs;
        C.Nameds = NamedArgs;
        return C;
    }

    /// <summary>
    /// Get a positional argument from a capture.
    /// </summary>
    /// <param name="Capture"></param>
    /// <param name="Pos"></param>
    /// <returns></returns>
    public static RakudoObject GetPositional(RakudoObject Capture, int Pos)
        throws NoSuchMethodException
    {
        P6capture.Instance NativeCapture = (P6capture.Instance)Capture;
        if (NativeCapture != null)
        {
            RakudoObject[] Possies = NativeCapture.Positionals;
            if (Possies != null && Pos < Possies.length)
                return Possies[Pos];
            else
                return null;
        }
        else
        {
            throw new NoSuchMethodException("Can only deal with native captures at the moment");
        }
    }

    /// <summary>
    /// Number of positionals.
    /// </summary>
    /// <param name="Capture"></param>
    /// <returns></returns>
    public static int NumPositionals(RakudoObject Capture)
         throws NoSuchMethodException
    {
        P6capture.Instance NativeCapture = (P6capture.Instance) Capture;
        if (NativeCapture != null)
        {
            RakudoObject[] Possies = NativeCapture.Positionals;
            return Possies == null ? 0 : Possies.length;
        }
        else
        {
            throw new NoSuchMethodException("Can only deal with native captures at the moment");
        }
    }

    /// <summary>
    /// Get a named argument from a capture.
    /// </summary>
    /// <param name="Capture"></param>
    /// <param name="Pos"></param>
    /// <returns></returns>
    public static RakudoObject GetNamed(RakudoObject Capture, String name)
         throws NoSuchFieldException
    {
        P6capture.Instance NativeCapture = (P6capture.Instance)Capture;
        if (NativeCapture != null)
        {
            HashMap<String,RakudoObject> Nameds = NativeCapture.Nameds;
            if (Nameds != null && Nameds.containsKey(name))
                return Nameds.get(name);
                // return Nameds[name]; // the C# version
            else
                return null;
        }
        else
        {
            throw new NoSuchFieldException("Can only deal with native captures at the moment");
        }
    }

    /// <summary>
    /// Gets a positional and tries to unbox it to the given type.
    /// XXX In the future, we can make it call a coercion too, if
    /// needed.
    /// </summary>
    /// <param name="Capture"></param>
    /// <param name="Pos"></param>
    /// <returns></returns>
    public static String GetPositionalAsString(RakudoObject Capture, int Pos)
    {
        return null; // TODO
        // return Ops.unbox_str(null, GetPositional(Capture, Pos));
    }

    /// <summary>
    /// XXX This is very wrong...
    /// </summary>
    /// <returns></returns>
    public static RakudoObject Nil()
    {
        return null;
    }
}

