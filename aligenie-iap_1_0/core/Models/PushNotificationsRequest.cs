// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PushNotificationsRequest : TeaModel {
        /// <summary>
        /// <para>Input parameter object for message push.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public PushNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class PushNotificationsRequestNotificationUnicastRequest : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILL_ID, the value is the skill ID obtained from the webhook service.  </description></item>
            /// <item><description>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apk包名</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the Tmall Genie device ID, and each method corresponds to a different encoding type:  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name  </description></item>
            /// <item><description>SKILL_ID: Skill ID</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Debug flag. When the skill application is in the debug phase, setting this flag determines whether the retrieved skill application information is from the editing state or the online state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            /// <summary>
            /// <para>Message template ID obtained when applying for a message template on the Tmall Genie Application Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2iU81*****G9elJ</para>
            /// </summary>
            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            /// <summary>
            /// <para>Organization Identifier. This parameter is required only when the push type is <c>XX_UNION_XX</c>. If you obtain CatGenie device or user identifiers through multiple channels and need interoperability among them, you must request an organization from the platform. After approval, the platform will assign an organization identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>Placeholder information. For example, for the template [&quot;Hello, {nick}!&quot;], this could be {&quot;nick&quot;:&quot;Sweetie&quot;}. Additionally, within the placeholder parameters, you can append parameters to the application launch link to support hyperlinking to a specific address, such as: <c>{&quot;nick&quot;:&quot;Sweetie&quot;,&quot;_URL_SUFFIX_&quot;:&quot;xxx&quot;}</c>. The hyperlink address in the message pop-up will then be: application launch link + <c>${_URL_SUFFIX_}</c>. This feature only works for applications that have configured a launch link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;nick&quot;:&quot;张三&quot;}</para>
            /// </summary>
            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            /// <summary>
            /// <para>The target information for message push.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public PushNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class PushNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
                /// <summary>
                /// <para>The identity value corresponding to the Push Target Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2VpiDQ6aMjxz******Eo7r6e08oIVZ3fKrm5TyEfY=</para>
                /// </summary>
                [NameInMap("TargetIdentity")]
                [Validation(Required=false)]
                public string TargetIdentity { get; set; }

                /// <summary>
                /// <para>The type of the Push Target, indicating the type when obtaining the corresponding device or User Identifier:  </para>
                /// <list type="bullet">
                /// <item><description><c>DEVICE_UNION_ID</c>: device unionId  </description></item>
                /// <item><description><c>DEVICE_OPEN_ID</c>: device openId  </description></item>
                /// <item><description><c>USER_UNION_ID</c>: user unionId  </description></item>
                /// <item><description><c>USER_OPEN_ID</c>: user openId</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEVICE_OPEN_ID</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>Identity information.</para>
        /// </summary>
        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public PushNotificationsRequestTenantInfo TenantInfo { get; set; }
        public class PushNotificationsRequestTenantInfo : TeaModel {
        }

    }

}
