%include <arrays_csharp.i>;//
%include <typemaps.i>
CSHARP_ARRAYS(char *, string)
%typemap(imtype, inattributes="[System.Runtime.InteropServices.In,System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPArray, SizeParamIndex=0, ArraySubType=System.Runtime.InteropServices.UnmanagedType.LPStr)]") char *INPUT[] "string[]"
%apply char *INPUT[] { char *ppInstrumentID[]  }
%apply int &OUTPUT {int &iResult};