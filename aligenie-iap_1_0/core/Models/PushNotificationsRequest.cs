// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PushNotificationsRequest : TeaModel {
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public PushNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class PushNotificationsRequestNotificationUnicastRequest : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public PushNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class PushNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
                [NameInMap("TargetIdentity")]
                [Validation(Required=false)]
                public string TargetIdentity { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public PushNotificationsRequestTenantInfo TenantInfo { get; set; }
        public class PushNotificationsRequestTenantInfo : TeaModel {
        }

    }

}
