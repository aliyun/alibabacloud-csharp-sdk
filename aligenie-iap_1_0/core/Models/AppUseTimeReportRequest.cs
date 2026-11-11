// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class AppUseTimeReportRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AppUseTimeReportRequestDeviceInfo DeviceInfo { get; set; }
        public class AppUseTimeReportRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID.</description></item>
            /// <item><description>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device identity for Tmall Genie, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for Android application customer-side integration.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for cloud-side integration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to deviceOpenId or deviceUnionId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: Default device ID.  </description></item>
            /// <item><description>UNION_ID: Organization-dimension device ID, available only after an organization has been requested in the Tmall Genie Skill Application Open Platform.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID, required if IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Business parameters</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public AppUseTimeReportRequestPayload Payload { get; set; }
        public class AppUseTimeReportRequestPayload : TeaModel {
            /// <summary>
            /// <para>Action item</para>
            /// <list type="bullet">
            /// <item><description>start indicates Start</description></item>
            /// <item><description>end indicates End</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Indicates whether the benefit is exclusive to members:</para>
            /// <list type="bullet">
            /// <item><description>1 indicates Yes  </description></item>
            /// <item><description>0 indicates No</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPrivilege")]
            [Validation(Required=false)]
            public int? IsPrivilege { get; set; }

            /// <summary>
            /// <para>Resource ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>Resource type:</para>
            /// <list type="bullet">
            /// <item><description>0 indicates game</description></item>
            /// <item><description>1 indicates audio</description></item>
            /// <item><description>2 indicates video</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public int? ResourceType { get; set; }

            /// <summary>
            /// <para>Step code. The start and end actions must be uniquely matched.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StepCode")]
            [Validation(Required=false)]
            public string StepCode { get; set; }

            /// <summary>
            /// <para>Membership type:</para>
            /// <list type="bullet">
            /// <item><description>0 indicates Cat Spirit Membership</description></item>
            /// <item><description>1 indicates third-party proprietary membership</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VipType")]
            [Validation(Required=false)]
            public int? VipType { get; set; }

            /// <summary>
            /// <para>Plaintext UUID</para>
            /// 
            /// <b>Example:</b>
            /// <para>731D5F********DC3B</para>
            /// </summary>
            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

        }

        /// <summary>
        /// <para>User identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public AppUseTimeReportRequestUserInfo UserInfo { get; set; }
        public class AppUseTimeReportRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type  </para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID.  </description></item>
            /// <item><description>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client application.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the user identifier from Tmall Genie, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer flow.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud-based flow.</description></item>
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
            /// <para>User identifier, set to either userOpenId or userUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: Default User ID identifier.  </description></item>
            /// <item><description>UNION_ID: Organization-dimension User ID identifier. This value is available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</description></item>
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
