// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class ListPublishedAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of published applications.</para>
        /// </summary>
        [NameInMap("AppModels")]
        [Validation(Required=false)]
        public List<ListPublishedAppInfoResponseBodyAppModels> AppModels { get; set; }
        public class ListPublishedAppInfoResponseBodyAppModels : TeaModel {
            /// <summary>
            /// <para>The application image ID. You can obtain the ID from the Image Management page in the WUYING Cloud App console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-f37nddbjc1lje14st</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-fxwp4koyr5y2sp4mz</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Microsoft Word</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The theme color of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("AppThemeColor")]
            [Validation(Required=false)]
            public string AppThemeColor { get; set; }

            /// <summary>
            /// <para>The application version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R2021a</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The application version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0</para>
            /// </summary>
            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            /// <summary>
            /// <para>The authorization time of the application.
            /// The return value is a serialized datetime string from the server in the format of <c>EEE MMM dd HH:mm:ss zzz yyyy</c>, which represents the day of the week, month, day, hour:minute:second, time zone abbreviation, and year in sequence. For example, <c>Wed Jan 14 20:47:02 CST 2026</c>, where <c>CST</c> is the time zone abbreviation of the server\&quot;s time zone (China Standard Time, UTC+08:00).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wed Jan 14 20:47:02 CST 2026</para>
            /// </summary>
            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public string AuthTime { get; set; }

            /// <summary>
            /// <para>The specific category information of the application, which is the secondary category.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: All applications</description></item>
            /// <item><description>2: Design software</description></item>
            /// <item><description>3: Programming and development</description></item>
            /// <item><description>4: Office essentials</description></item>
            /// <item><description>5: Input methods</description></item>
            /// <item><description>6: Image and video</description></item>
            /// <item><description>7: System tools</description></item>
            /// <item><description>8: Browsers</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The primary category of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Cloud application</description></item>
            /// <item><description>1: Cloud game</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public long? CategoryType { get; set; }

            /// <summary>
            /// <para>The URL of the application icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://app-streaming-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1973619010349344/1634523814270_Matlab.png">https://app-streaming-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1973619010349344/1634523814270_Matlab.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the user has permissions.
            /// The value is True.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsAuth")]
            [Validation(Required=false)]
            public bool? IsAuth { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("UsedInSession")]
            [Validation(Required=false)]
            public bool? UsedInSession { get; set; }

        }

        /// <summary>
        /// <para>The starting token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2NVfhLfgy5b3J5iJyoLQ6x4EULMg1hbhgB9NfnvdK9oj5zwxd17j4TuQkZze3RvhEvBinZYjknujF3Q1M</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB70F8FE-63A3-587B-8560-CEC258E8B944</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
