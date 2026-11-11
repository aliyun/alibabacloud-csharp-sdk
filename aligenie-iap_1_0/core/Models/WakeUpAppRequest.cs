// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class WakeUpAppRequest : TeaModel {
        /// <summary>
        /// <para>The debug identity. When the skill application is in the debugging phase, this setting determines whether the retrieved skill application information is from the editing state or the online state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDebug")]
        [Validation(Required=false)]
        public bool? IsDebug { get; set; }

        /// <summary>
        /// <para>The path to launch the application, similar to the Link you enter in the skill application console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>应用拉起路径</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Device Information of the target to be launched.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public WakeUpAppRequestTargetInfo TargetInfo { get; set; }
        public class WakeUpAppRequestTargetInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILLID, the value is the skill ID obtained from the webhook service.  </description></item>
            /// <item><description>When the encoding type is PACKAGENAME, the value is the packageName of the corresponding client application.</description></item>
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
            /// <para>Encoding type. There are multiple ways to obtain the MeowGenie device ID, and each method corresponds to a different encoding type:  </para>
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
            /// <para>Organization ID. This is required only when the push type is <c>XX_UNION_XX</c>. If you have multiple methods to obtain MeowGenie device IDs and need interoperability among them, you must request an organization from the platform. After approval, the platform will assign an organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The identity value corresponding to the Push Target Type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2VpiDQ6aMjxz******Eo7r6e08oIVZ3fKrm5TyEfY=</para>
            /// </summary>
            [NameInMap("TargetIdentity")]
            [Validation(Required=false)]
            public string TargetIdentity { get; set; }

            /// <summary>
            /// <para>Push Target Type, which indicates the type of the obtained device identity:  </para>
            /// <list type="bullet">
            /// <item><description><c>DEVICE_UNION_ID</c>: Device unionId  </description></item>
            /// <item><description><c>DEVICE_OPEN_ID</c>: Device openId</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEVICE_OPEN_ID</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
