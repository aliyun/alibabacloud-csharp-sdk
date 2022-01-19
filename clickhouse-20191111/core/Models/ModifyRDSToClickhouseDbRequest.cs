// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyRDSToClickhouseDbRequest : TeaModel {
        [NameInMap("CkPassword")]
        [Validation(Required=false)]
        public string CkPassword { get; set; }

        [NameInMap("CkUserName")]
        [Validation(Required=false)]
        public string CkUserName { get; set; }

        [NameInMap("ClickhousePort")]
        [Validation(Required=false)]
        public long? ClickhousePort { get; set; }

        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        [NameInMap("LimitUpper")]
        [Validation(Required=false)]
        public long? LimitUpper { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RdsId")]
        [Validation(Required=false)]
        public string RdsId { get; set; }

        [NameInMap("RdsPassword")]
        [Validation(Required=false)]
        public string RdsPassword { get; set; }

        [NameInMap("RdsPort")]
        [Validation(Required=false)]
        public long? RdsPort { get; set; }

        [NameInMap("RdsSynDb")]
        [Validation(Required=false)]
        public string RdsSynDb { get; set; }

        [NameInMap("RdsSynTables")]
        [Validation(Required=false)]
        public string RdsSynTables { get; set; }

        [NameInMap("RdsUserName")]
        [Validation(Required=false)]
        public string RdsUserName { get; set; }

        [NameInMap("RdsVpcId")]
        [Validation(Required=false)]
        public string RdsVpcId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SkipUnsupported")]
        [Validation(Required=false)]
        public bool? SkipUnsupported { get; set; }

    }

}
