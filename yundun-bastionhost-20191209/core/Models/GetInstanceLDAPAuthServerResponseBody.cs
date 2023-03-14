// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceLDAPAuthServerResponseBody : TeaModel {
        /// <summary>
        /// The settings of LDAP authentication.
        /// </summary>
        [NameInMap("LDAP")]
        [Validation(Required=false)]
        public GetInstanceLDAPAuthServerResponseBodyLDAP LDAP { get; set; }
        public class GetInstanceLDAPAuthServerResponseBodyLDAP : TeaModel {
            /// <summary>
            /// The account of the LDAP server.
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// The Base distinguished name (DN).
            /// </summary>
            [NameInMap("BaseDN")]
            [Validation(Required=false)]
            public string BaseDN { get; set; }

            /// <summary>
            /// The field that is used to indicate the email address of a user on the LDAP server.
            /// </summary>
            [NameInMap("EmailMapping")]
            [Validation(Required=false)]
            public string EmailMapping { get; set; }

            /// <summary>
            /// The condition that is used to filter users.
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// Indicates whether passwords are required. Valid values:
            /// 
            /// *   **true**: required
            /// *   **false**: not required
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }

            /// <summary>
            /// Indicates whether SSL is supported. Valid values:
            /// 
            /// *   **true**: supported
            /// *   **false**: not supported
            /// </summary>
            [NameInMap("IsSSL")]
            [Validation(Required=false)]
            public bool? IsSSL { get; set; }

            /// <summary>
            /// The field that is used to indicate the logon name of a user on the LDAP server.
            /// </summary>
            [NameInMap("LoginNameMapping")]
            [Validation(Required=false)]
            public string LoginNameMapping { get; set; }

            /// <summary>
            /// The field that is used to indicate the mobile phone number of a user on the LDAP server.
            /// </summary>
            [NameInMap("MobileMapping")]
            [Validation(Required=false)]
            public string MobileMapping { get; set; }

            /// <summary>
            /// The field that is used to indicate the name of a user on the LDAP server.
            /// </summary>
            [NameInMap("NameMapping")]
            [Validation(Required=false)]
            public string NameMapping { get; set; }

            /// <summary>
            /// The port that is used to access the LDAP server.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// The address of the LDAP server.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The address of the secondary LDAP server.
            /// </summary>
            [NameInMap("StandbyServer")]
            [Validation(Required=false)]
            public string StandbyServer { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
