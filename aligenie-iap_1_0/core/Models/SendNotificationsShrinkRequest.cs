// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class SendNotificationsShrinkRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public string NotificationUnicastRequestShrink { get; set; }

        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public string TenantInfoShrink { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
