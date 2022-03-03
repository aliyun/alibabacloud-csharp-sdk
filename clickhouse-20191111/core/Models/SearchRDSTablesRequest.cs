// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class SearchRDSTablesRequest : TeaModel {
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

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

        [NameInMap("RdsUserName")]
        [Validation(Required=false)]
        public string RdsUserName { get; set; }

        [NameInMap("RdsVpcUrl")]
        [Validation(Required=false)]
        public string RdsVpcUrl { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
