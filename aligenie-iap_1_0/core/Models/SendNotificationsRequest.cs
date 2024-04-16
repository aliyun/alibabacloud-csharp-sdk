// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class SendNotificationsRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestDeviceInfo DeviceInfo { get; set; }
        public class SendNotificationsRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public SendNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class SendNotificationsRequestNotificationUnicastRequest : TeaModel {
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public SendNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class SendNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
            }

        }

        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestTenantInfo TenantInfo { get; set; }
        public class SendNotificationsRequestTenantInfo : TeaModel {
        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestUserInfo UserInfo { get; set; }
        public class SendNotificationsRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
