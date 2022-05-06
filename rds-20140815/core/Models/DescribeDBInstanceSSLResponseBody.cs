// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        [NameInMap("ClientCACertExpireTime")]
        [Validation(Required=false)]
        public string ClientCACertExpireTime { get; set; }

        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        [NameInMap("ReplicationACL")]
        [Validation(Required=false)]
        public string ReplicationACL { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequireUpdate")]
        [Validation(Required=false)]
        public string RequireUpdate { get; set; }

        [NameInMap("RequireUpdateItem")]
        [Validation(Required=false)]
        public string RequireUpdateItem { get; set; }

        [NameInMap("RequireUpdateReason")]
        [Validation(Required=false)]
        public string RequireUpdateReason { get; set; }

        [NameInMap("SSLCreateTime")]
        [Validation(Required=false)]
        public string SSLCreateTime { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        [NameInMap("SSLExpireTime")]
        [Validation(Required=false)]
        public string SSLExpireTime { get; set; }

        [NameInMap("ServerCAUrl")]
        [Validation(Required=false)]
        public string ServerCAUrl { get; set; }

        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

    }

}
