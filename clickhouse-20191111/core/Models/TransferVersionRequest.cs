// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class TransferVersionRequest : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        [NameInMap("TargetAccount")]
        [Validation(Required=false)]
        public string TargetAccount { get; set; }

        [NameInMap("TargetDbClusterId")]
        [Validation(Required=false)]
        public string TargetDbClusterId { get; set; }

        [NameInMap("TargetPassword")]
        [Validation(Required=false)]
        public string TargetPassword { get; set; }

    }

}
