// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ChangeSlotStatusRequest : TeaModel {
        [NameInMap("AdSlotCorporateStatus")]
        [Validation(Required=false)]
        public string AdSlotCorporateStatus { get; set; }

        [NameInMap("AdSlotId")]
        [Validation(Required=false)]
        public string AdSlotId { get; set; }

        [NameInMap("AdSlotStatus")]
        [Validation(Required=false)]
        public string AdSlotStatus { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MessageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        [NameInMap("OriginSiteUserId")]
        [Validation(Required=false)]
        public string OriginSiteUserId { get; set; }

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
