// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class KerberosConf : TeaModel {
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("kerberosConfId")]
        [Validation(Required=false)]
        public string KerberosConfId { get; set; }

        [NameInMap("keytabs")]
        [Validation(Required=false)]
        public List<string> Keytabs { get; set; }

        [NameInMap("krb5Conf")]
        [Validation(Required=false)]
        public string Krb5Conf { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("networkServiceId")]
        [Validation(Required=false)]
        public string NetworkServiceId { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
