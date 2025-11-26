// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PrepayResource : TeaModel {
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

    }

}
