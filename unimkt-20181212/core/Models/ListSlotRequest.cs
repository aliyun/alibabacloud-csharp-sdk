// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ListSlotRequest : TeaModel {
        [NameInMap("AdSlotCorporateStatus")]
        [Validation(Required=false)]
        public string AdSlotCorporateStatus { get; set; }

        [NameInMap("AdSlotId")]
        [Validation(Required=false)]
        public string AdSlotId { get; set; }

        [NameInMap("AdSlotName")]
        [Validation(Required=false)]
        public string AdSlotName { get; set; }

        [NameInMap("AdSlotStatus")]
        [Validation(Required=false)]
        public string AdSlotStatus { get; set; }

        [NameInMap("AdSlotType")]
        [Validation(Required=false)]
        public string AdSlotType { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("MediaName")]
        [Validation(Required=false)]
        public string MediaName { get; set; }

        [NameInMap("OriginSiteUserId")]
        [Validation(Required=false)]
        public string OriginSiteUserId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartCreateTime")]
        [Validation(Required=false)]
        public long? StartCreateTime { get; set; }

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
