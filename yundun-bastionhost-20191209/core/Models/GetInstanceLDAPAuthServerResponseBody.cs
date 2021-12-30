// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceLDAPAuthServerResponseBody : TeaModel {
        [NameInMap("LDAP")]
        [Validation(Required=false)]
        public GetInstanceLDAPAuthServerResponseBodyLDAP LDAP { get; set; }
        public class GetInstanceLDAPAuthServerResponseBodyLDAP : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }
            [NameInMap("BaseDN")]
            [Validation(Required=false)]
            public string BaseDN { get; set; }
            [NameInMap("EmailMapping")]
            [Validation(Required=false)]
            public string EmailMapping { get; set; }
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }
            [NameInMap("IsSSL")]
            [Validation(Required=false)]
            public bool? IsSSL { get; set; }
            [NameInMap("LoginNameMapping")]
            [Validation(Required=false)]
            public string LoginNameMapping { get; set; }
            [NameInMap("MobileMapping")]
            [Validation(Required=false)]
            public string MobileMapping { get; set; }
            [NameInMap("NameMapping")]
            [Validation(Required=false)]
            public string NameMapping { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }
            [NameInMap("StandbyServer")]
            [Validation(Required=false)]
            public string StandbyServer { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
