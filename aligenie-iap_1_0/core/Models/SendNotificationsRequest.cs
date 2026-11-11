// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class SendNotificationsRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestDeviceInfo DeviceInfo { get; set; }
        public class SendNotificationsRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type. If the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID. If the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID for Maojing, and each method corresponds to a different encoding type:  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer link  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud link</description></item>
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
            /// <para>Device ID (deviceOpenId or deviceUnionId)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID:  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: Default device ID  </description></item>
            /// <item><description>UNION_ID: Organization-dimension device ID, available only after an organization has been requested on the Maojing Skill Application Open Platform</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required if IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Input parameter object for message push.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public SendNotificationsRequestNotificationUnicastRequest NotificationUnicastRequest { get; set; }
        public class SendNotificationsRequestNotificationUnicastRequest : TeaModel {
            /// <summary>
            /// <para>Debug flag. When the skill application is in the debugging phase, setting this flag determines whether the retrieved skill application information is from the editing state or the online state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            /// <summary>
            /// <para>Message template ID obtained when requesting a message template in the Tmall Genie Application Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2iU81*****G9elJ</para>
            /// </summary>
            [NameInMap("MessageTemplateId")]
            [Validation(Required=false)]
            public string MessageTemplateId { get; set; }

            /// <summary>
            /// <para>Placeholder information. For example, for the template [&quot;Hello, {nick}!&quot;], this can be: {&quot;nick&quot;:&quot;Xiao Tian Tian&quot;}. Additionally, within the placeholder parameters, you can append parameters to the application launch link to support hyperlinking to a specific address, such as: <c>{&quot;nick&quot;:&quot;Xiao Tian Tian&quot;,&quot;_URL_SUFFIX_&quot;:&quot;xxx&quot;}</c>. The hyperlink address in the message pop-up will then be: application launch link + <c>${_URL_SUFFIX_}</c>. This feature is only effective for applications that have configured a launch link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;nick&quot;:&quot;张三&quot;}</para>
            /// </summary>
            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaceHolder { get; set; }

            /// <summary>
            /// <para>Target information for message push.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SendTarget")]
            [Validation(Required=false)]
            public SendNotificationsRequestNotificationUnicastRequestSendTarget SendTarget { get; set; }
            public class SendNotificationsRequestNotificationUnicastRequestSendTarget : TeaModel {
            }

        }

        /// <summary>
        /// <para>Identity information.</para>
        /// </summary>
        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestTenantInfo TenantInfo { get; set; }
        public class SendNotificationsRequestTenantInfo : TeaModel {
        }

        /// <summary>
        /// <para>User Identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SendNotificationsRequestUserInfo UserInfo { get; set; }
        public class SendNotificationsRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type. If the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID. If the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the Maojing User Identifier, and each method corresponds to a different encoding type:  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer link  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud-based link</description></item>
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
            /// <para>User Identifier (userOpenId or userUnionId)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of the User ID:  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: Default User ID identifier  </description></item>
            /// <item><description>UNION_ID: Organization-dimension User ID identifier, available only after an organization has been requested on the Maojing Skill Application Open Platform</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required if IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
