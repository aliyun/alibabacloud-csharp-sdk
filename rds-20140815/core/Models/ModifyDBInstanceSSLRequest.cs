// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        [NameInMap("ACL")]
        [Validation(Required=false)]
        public string ACL { get; set; }

        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        [NameInMap("ClientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        [NameInMap("ClientCAEnabled")]
        [Validation(Required=false)]
        public int? ClientCAEnabled { get; set; }

        [NameInMap("ClientCertRevocationList")]
        [Validation(Required=false)]
        public string ClientCertRevocationList { get; set; }

        [NameInMap("ClientCrlEnabled")]
        [Validation(Required=false)]
        public int? ClientCrlEnabled { get; set; }

        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ReplicationACL")]
        [Validation(Required=false)]
        public string ReplicationACL { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

    }

}
