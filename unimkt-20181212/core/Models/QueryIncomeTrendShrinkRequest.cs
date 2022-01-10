// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryIncomeTrendShrinkRequest : TeaModel {
        [NameInMap("AdSlotId")]
        [Validation(Required=false)]
        public string AdSlotId { get; set; }

        [NameInMap("AdSlotName")]
        [Validation(Required=false)]
        public string AdSlotName { get; set; }

        [NameInMap("AdSlotType")]
        [Validation(Required=false)]
        public string AdSlotType { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("MediaName")]
        [Validation(Required=false)]
        public string MediaNameShrink { get; set; }

        [NameInMap("OriginSiteUserId")]
        [Validation(Required=false)]
        public string OriginSiteUserId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("Slot")]
        [Validation(Required=false)]
        public long? Slot { get; set; }

        [NameInMap("SlotDimension")]
        [Validation(Required=false)]
        public string SlotDimension { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserSite")]
        [Validation(Required=false)]
        public string UserSite { get; set; }

    }

}
