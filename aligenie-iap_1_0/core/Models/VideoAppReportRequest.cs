// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class VideoAppReportRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public VideoAppReportRequestDeviceInfo DeviceInfo { get; set; }
        public class VideoAppReportRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>编码类型对应的值</para>
            /// <list type="bullet">
            /// <item><description>编码类型是SKILL_ID时，其值为应用的Skill ID。</description></item>
            /// <item><description>编码类型是PACKAGE_NAME时，其值为对应客户端App的packageName。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID from Tmall Genie, and each method corresponds to a different encoding type.</para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for Android application customer flows.</description></item>
            /// <item><description>SKILL_ID: Skill ID, used for cloud-based flows.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to either deviceOpenId or deviceUnionId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of the device ID.</para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default device ID.</description></item>
            /// <item><description>UNION_ID: Organization-level device ID. This value is available only after an organization has been registered on the Tmall Genie Skill Application Open Platform.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required when IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>业务参数</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public VideoAppReportRequestPayload Payload { get; set; }
        public class VideoAppReportRequestPayload : TeaModel {
            /// <summary>
            /// <para>会员的结束时间。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652337963097</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>会员是否登录。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isLogin")]
            [Validation(Required=false)]
            public bool? IsLogin { get; set; }

            /// <summary>
            /// <para>该账号是否为会员。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isVip")]
            [Validation(Required=false)]
            public bool? IsVip { get; set; }

            /// <summary>
            /// <para>账号的昵称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("loginNick")]
            [Validation(Required=false)]
            public string LoginNick { get; set; }

            /// <summary>
            /// <para>明文uuid</para>
            /// 
            /// <b>Example:</b>
            /// <para>731D5F********DC3B</para>
            /// </summary>
            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

            /// <summary>
            /// <para>账户的手机号码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>188*777</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>应用包名。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.***.test</para>
            /// </summary>
            [NameInMap("pkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            /// <summary>
            /// <para>会员的开始时间。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652337963097</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>用户标识信息</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public VideoAppReportRequestUserInfo UserInfo { get; set; }
        public class VideoAppReportRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>编码类型对应的值</para>
            /// <list type="bullet">
            /// <item><description>编码类型是SKILL_ID时，其值为应用的Skill ID。</description></item>
            /// <item><description>编码类型是PACKAGE_NAME时，其值为对应客户端App的packageName。</description></item>
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
            /// <para>编码类型，获取天猫精灵的用户标识的途径有多种，不同途径对应不同的编码类型。</para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME：apk包名，Android应用客户链路的编码类型。</description></item>
            /// <item><description>SKILL_ID：技能ID，云端链路的编码类型。</description></item>
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
            /// <para>用户标识，设置为userOpenId或userUnionId。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>用户Id的类型  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID：默认的用户ID标识。</description></item>
            /// <item><description>UNION_ID: 组织维度的用户ID标识，在天猫精灵技能应用开放平台申请过组织后才会有该值。</description></item>
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
            /// <para>组织ID，如果IdType为UNION_ID时必填。</para>
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
