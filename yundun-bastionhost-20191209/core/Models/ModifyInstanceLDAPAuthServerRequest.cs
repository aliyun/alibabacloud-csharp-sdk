// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceLDAPAuthServerRequest : TeaModel {
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

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsSSL")]
        [Validation(Required=false)]
        public string IsSSL { get; set; }

        [NameInMap("LoginNameMapping")]
        [Validation(Required=false)]
        public string LoginNameMapping { get; set; }

        [NameInMap("MobileMapping")]
        [Validation(Required=false)]
        public string MobileMapping { get; set; }

        [NameInMap("NameMapping")]
        [Validation(Required=false)]
        public string NameMapping { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Server")]
        [Validation(Required=false)]
        public string Server { get; set; }

        [NameInMap("StandbyServer")]
        [Validation(Required=false)]
        public string StandbyServer { get; set; }

    }

}
