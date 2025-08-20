// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PushNotificationsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public PushNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class PushNotificationsRequestNotificationUnicastRequest : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apk包名</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2iU81*****G9elJ</para>
            /// </summary>
            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;nick&quot;:&quot;张三&quot;}</para>
            /// </summary>
            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public PushNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class PushNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2VpiDQ6aMjxz******Eo7r6e08oIVZ3fKrm5TyEfY=</para>
                /// </summary>
                [NameInMap("TargetIdentity")]
                [Validation(Required=false)]
                public string TargetIdentity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEVICE_OPEN_ID</para>
                /// </summary>
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
