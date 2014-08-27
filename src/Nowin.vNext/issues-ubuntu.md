 kpm restore
Restoring packages for /tmp/ASP.net.vNext.davidfowl.HelloWorldVNext/src/helloworldweb/project.json
before restoring packages
Attempting to resolve dependency helloworldweb >= 1.0.0
Attempting to resolve dependency Kestrel >= 1.0.0
Attempting to resolve dependency Nowin.vNext >=
Attempting to resolve dependency Nowin >= 0.11.0
Attempting to resolve dependency Microsoft.AspNet.Hosting >= 1.0.0
Attempting to resolve dependency Microsoft.AspNet.Owin >= 1.0.0
Attempting to resolve dependency Microsoft.AspNet.WebSockets.Server >= 1.0.0
Attempting to resolve dependency mscorlib >=
Attempting to resolve dependency System >=
Attempting to resolve dependency System.Core >=
Attempting to resolve dependency Microsoft.CSharp >=
ERROR building certificate chain: System.NullReferenceException: Object reference not set to an instance of an object
  at System.Security.Cryptography.X509Certificates.X509Chain.get_Roots () [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.get_CertificateCollection () [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.FindParent (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.BuildChainFrom (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.Build (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Net.ServicePointManager+ChainValidationHelper.ValidateChain (Mono.Security.X509.X509CertificateCollection certs) [0x00000] in <filename unknown>:0
Please, report this problem to the Mono team
ERROR processing certificate: System.Security.Cryptography.CryptographicException: Certificate instance is empty.
  at System.Security.Cryptography.X509Certificates.X509Certificate2.get_Version () [0x00000] in <filename unknown>:0
  at System.Net.ServicePointManager+ChainValidationHelper.CheckCertificateUsage (System.Security.Cryptography.X509Certificates.X509Certificate2 cert) [0x00000] in <filename unknown>:0
Please, report this problem to the Mono team
ERROR building certificate chain: System.NullReferenceException: Object reference not set to an instance of an object
  at System.Security.Cryptography.X509Certificates.X509Chain.get_Roots () [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.get_CertificateCollection () [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.FindParent (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.BuildChainFrom (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Security.Cryptography.X509Certificates.X509Chain.Build (System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) [0x00000] in <filename unknown>:0
  at System.Net.ServicePointManager+ChainValidationHelper.ValidateChain (Mono.Security.X509.X509CertificateCollection certs) [0x00000] in <filename unknown>:0
Please, report this problem to the Mono team
ERROR processing certificate: System.NullReferenceException: Object reference not set to an instance of an object
  at System.Security.Cryptography.X509Certificates.X509Certificate2.get_Version () [0x00000] in <filename unknown>:0
  at System.Net.ServicePointManager+ChainValidationHelper.CheckCertificateUsage (System.Security.Cryptography.X509Certificates.X509Certificate2 cert) [0x00000] in <filename unknown>:0
Please, report this problem to the Mono team
Stacktrace:


Native stacktrace:

        mono() [0x81079aa]
        mono() [0x8156374]
        mono() [0x806971b]
        [0xb779e40c]
        mono() [0x824571b]
        mono() [0x8246907]
        mono() [0x821b31d]
        mono() [0x8220aa9]
        mono() [0x8221269]
        mono() [0x82215d0]
        mono() [0x823ca6a]
        mono() [0x823cc8f]
        mono(mono_array_new_full+0x1c4) [0x81fa294]
        mono() [0x81fb41c]
        mono(mono_array_clone+0x18) [0x81fb478]
        [0xb5a1b718]
        /usr/local/lib/mono/4.5/mscorlib.dll.so(+0x4e0c1) [0xb5a910c1]
        /usr/local/lib/mono/4.5/mscorlib.dll.so(+0x4d8ed) [0xb5a908ed]
        /usr/local/lib/mono/4.5/mscorlib.dll.so(+0x28c988) [0xb5ccf988]
        [0xb50739e0]
        [0xb5073722]
        [0xb50761b8]
        [0xb5075758]
        [0xb507562c]
        [0xb50754c8]
        [0xb5075350]
        [0xb5074fd4]
        [0xb5074820]
        [0xb5073088]
        [0xb5072e15]
        [0xb5072df2]
        [0xb5072dc4]
        [0xb5072ca6]
        [0xb5072c18]
        [0xb506fb70]
        [0xb5068ad6]
        [0xb5068a58]
        [0xb506e1c8]
        [0xb506d0a4]
        [0xb72abd75]
        mono() [0x8069235]

Debug info from gdb:


=================================================================
Got a SIGSEGV while executing native code. This usually indicates
a fatal error in the mono runtime or one of the native libraries
used by your application.
=================================================================

/root/.kre/packages/KRE-mono45-x86.1.0.0-alpha3/bin/klr: line 15:  3032 Aborted                 (core dumped) mono "$DIR/klr.mono.managed.dll" "$@"
