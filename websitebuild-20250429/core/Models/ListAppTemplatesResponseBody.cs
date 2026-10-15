// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access is denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retries are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The app name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not used and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The number of results returned per query. Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppTemplatesResponseBodyModule Module { get; set; }
        public class ListAppTemplatesResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>The request results.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAppTemplatesResponseBodyModuleData> Data { get; set; }
            public class ListAppTemplatesResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>The application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The application instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WD20250703155602000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The color scheme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Red</para>
                /// </summary>
                [NameInMap("ColorScheme")]
                [Validation(Required=false)]
                public string ColorScheme { get; set; }

                /// <summary>
                /// <para>The color scheme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("ColorSchemeName")]
                [Validation(Required=false)]
                public string ColorSchemeName { get; set; }

                /// <summary>
                /// <para>The actual amount of data copied from the original table during a DMS lock-free change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CopyCount")]
                [Validation(Required=false)]
                public int? CopyCount { get; set; }

                /// <summary>
                /// <para>The creator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SOAR</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creation time. The time is displayed in ISO 8601 format in UTC (Z).</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-20T02:26:38Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The modification time. The time is a UNIX timestamp in milliseconds.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1627545952000</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9953352</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The industry of the file to be analyzed. Default value: <b>common</b> (general industry). Select an appropriate industry so that the backend can match the applicable algorithm combination. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>microVideo</b>: short video industry</description></item>
                /// <item><description><b>common</b>: general industry</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NOUSE</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>The industry name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("IndustryName")]
                [Validation(Required=false)]
                public string IndustryName { get; set; }

                /// <summary>
                /// <para>Specifies whether the template is recommended.</para>
                /// </summary>
                [NameInMap("IsRecommended")]
                [Validation(Required=false)]
                public bool? IsRecommended { get; set; }

                /// <summary>
                /// <para>The last modifier ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The number of likes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LikeCount")]
                [Validation(Required=false)]
                public int? LikeCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the current user has liked the item.</para>
                /// </summary>
                [NameInMap("Liked")]
                [Validation(Required=false)]
                public bool? Liked { get; set; }

                /// <summary>
                /// <para>The repair action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;memFrom\&quot;: \&quot;text\&quot;, \&quot;uid\&quot;: \&quot;text\&quot;, \&quot;labels\&quot;: \&quot;jsonb\&quot;, \&quot;content\&quot;: \&quot;text\&quot;, \&quot;fromId\&quot;: \&quot;text\&quot;, \&quot;uuid\&quot;: \&quot;text\&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// <para>The preview URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://preview-lyj.aliyuncs.com/preview/b2c5a245c44946b99cf5435210bbb8b8?subSceneIds=728166">https://preview-lyj.aliyuncs.com/preview/b2c5a245c44946b99cf5435210bbb8b8?subSceneIds=728166</a></para>
                /// </summary>
                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

                /// <summary>
                /// <para>The product version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BasicVersion</b>: Basic Edition</description></item>
                /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseVersion</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// <para>The edition name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.1</para>
                /// </summary>
                [NameInMap("ProductVersionName")]
                [Validation(Required=false)]
                public string ProductVersionName { get; set; }

                /// <summary>
                /// <para>The number of shares.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ShareCount")]
                [Validation(Required=false)]
                public int? ShareCount { get; set; }

                /// <summary>
                /// <para>The file status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de10bf7d782392a70f293a3b1f7bb8fc</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// <list type="bullet">
                /// <item><description>The maximum length is 128 characters.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cfdna6</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The application thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("ThumbnailUrl")]
                [Validation(Required=false)]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// <para>The number of views.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public int? ViewCount { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The decision weight.</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public ListAppTemplatesResponseBodyModuleNext Next { get; set; }
            public class ListAppTemplatesResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <para>The application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The bizId of the associated application instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20260502160409000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The color scheme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("ColorScheme")]
                [Validation(Required=false)]
                public string ColorScheme { get; set; }

                /// <summary>
                /// <para>The color scheme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("ColorSchemeName")]
                [Validation(Required=false)]
                public string ColorSchemeName { get; set; }

                /// <summary>
                /// <para>The actual amount of data copied from the original table during a DMS lock-free change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CopyCount")]
                [Validation(Required=false)]
                public int? CopyCount { get; set; }

                /// <summary>
                /// <para>The tenant user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>208116853206125255</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-17 20:43:21</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-18T10:03:56+08:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000039405002</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The industry. Default value: <b>common</b> (General industry). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>microVideo</b>: Short video industry.</para>
                /// </description></item>
                /// <item><description><para><b>common</b>: General industry.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NOUSE</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>The industry name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("IndustryName")]
                [Validation(Required=false)]
                public string IndustryName { get; set; }

                /// <summary>
                /// <para>Specifies whether the template is recommended.</para>
                /// </summary>
                [NameInMap("IsRecommended")]
                [Validation(Required=false)]
                public bool? IsRecommended { get; set; }

                /// <summary>
                /// <para>The ID of the last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The number of likes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LikeCount")]
                [Validation(Required=false)]
                public int? LikeCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the current user has liked the item.</para>
                /// </summary>
                [NameInMap("Liked")]
                [Validation(Required=false)]
                public bool? Liked { get; set; }

                /// <summary>
                /// <para>The fix details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;knowledge_point\&quot;:\&quot;text\&quot;,\&quot;trunk_id\&quot;:\&quot;text\&quot;,\&quot;doc_name\&quot;:\&quot;text\&quot;,\&quot;knowledge_point_id\&quot;:\&quot;text\&quot;,\&quot;doc_id\&quot;:\&quot;text\&quot;,\&quot;trunk_content\&quot;:\&quot;text\&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// <para>The preview URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://preview-lyj.aliyuncs.com/preview/b989c9ac526e4fb48e018805f43d5fb1?subSceneIds=816576">https://preview-lyj.aliyuncs.com/preview/b989c9ac526e4fb48e018805f43d5fb1?subSceneIds=816576</a></para>
                /// </summary>
                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

                /// <summary>
                /// <para>The product version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BasicVersion</b>: Basic Edition.</description></item>
                /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition.<remarks>
                /// <para>Specify this parameter only when ProductForm is set to IntegrationForm.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BasicVersion</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// <para>The edition name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.2</para>
                /// </summary>
                [NameInMap("ProductVersionName")]
                [Validation(Required=false)]
                public string ProductVersionName { get; set; }

                /// <summary>
                /// <para>The number of shares.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ShareCount")]
                [Validation(Required=false)]
                public int? ShareCount { get; set; }

                /// <summary>
                /// <para>The status. Valid values: unknown, init, testing, and online.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3802aefc8cb0003b71286c47afc83624</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iem</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The application thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("ThumbnailUrl")]
                [Validation(Required=false)]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// <para>The number of views.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public int? ViewCount { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether a previous page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            /// <summary>
            /// <para>Indicates whether the query result is truncated. In addition to the pagination limit, the server processes a maximum of the latest 1,000 records for the current query. If the number of results exceeds 1,000, <b>ResultLimit</b> is set to <b>true</b>. In this case, narrow the time range and search again. Otherwise, <b>ResultLimit</b> is set to <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query. This parameter is empty if there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3BFw8paIJ7ylB6A7Qn9JjM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
