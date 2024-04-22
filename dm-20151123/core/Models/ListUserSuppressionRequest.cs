// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListUserSuppressionRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("EndBounceTime")]
        [Validation(Required=false)]
        public int? EndBounceTime { get; set; }

        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public int? EndCreateTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartBounceTime")]
        [Validation(Required=false)]
        public int? StartBounceTime { get; set; }

        [NameInMap("StartCreateTime")]
        [Validation(Required=false)]
        public int? StartCreateTime { get; set; }

    }

}
