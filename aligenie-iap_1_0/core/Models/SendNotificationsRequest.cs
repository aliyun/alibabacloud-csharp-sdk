// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class SendNotificationsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestDeviceInfo DeviceInfo { get; set; }
        public class SendNotificationsRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public SendNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class SendNotificationsRequestNotificationUnicastRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
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
            public SendNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class SendNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
            }

        }

        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestTenantInfo TenantInfo { get; set; }
        public class SendNotificationsRequestTenantInfo : TeaModel {
        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestUserInfo UserInfo { get; set; }
        public class SendNotificationsRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
