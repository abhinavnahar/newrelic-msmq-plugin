using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MSMQNewRelicPlugin
{
    class MSMQConnectionUtil
    {

        public static MSMQConnectSession connect(String host, String domain, String username, String password) {
            SecureString securepassword = new SecureString();
            foreach (Char p in password.ToCharArray()) {
                securepassword.AppendChar(p);
            }
           
           
            CimCredential Credentials = new CimCredential(PasswordAuthenticationMechanism.Kerberos
                 + "", domain, username, securepassword);

            WSManSessionOptions SessionOptions = new WSManSessionOptions();
            SessionOptions.AddDestinationCredentials(Credentials);

            return new MSMQConnectSession(CimSession.Create(host, SessionOptions));
        }
        
    }
}
