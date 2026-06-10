// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>permission denied information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ish-intelligence-store-platform-admin-web</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>dynamic error Code</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>dynamic error message, used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> error message.  </para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>whether deletion succeeded</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppTemplateResponseBodyModule Module { get; set; }
        public class GetAppTemplateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Application type</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>Business ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>color</para>
            /// 
            /// <b>Example:</b>
            /// <para>red</para>
            /// </summary>
            [NameInMap("ColorScheme")]
            [Validation(Required=false)]
            public string ColorScheme { get; set; }

            /// <summary>
            /// <para>Color name</para>
            /// 
            /// <b>Example:</b>
            /// <para>red</para>
            /// </summary>
            [NameInMap("ColorSchemeName")]
            [Validation(Required=false)]
            public string ColorSchemeName { get; set; }

            /// <summary>
            /// <para>The actual data volume of the original table copied during DMS lockless change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CopyCount")]
            [Validation(Required=false)]
            public int? CopyCount { get; set; }

            /// <summary>
            /// <para>User ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>208614160512124381</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Creation UTC time, in ISO 8601 date format.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-04T01:40:25Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Modify time</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-05T11:16:57.785Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>Primary key</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Industry. Default value: <b>common</b> (general industry). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>microVideo</b>: Short video industry.</para>
            /// </description></item>
            /// <item><description><para><b>common</b>: General industry.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>通用</para>
            /// </summary>
            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>Industry name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>indextry</para>
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>Last modifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            /// <summary>
            /// <para>Like count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("LikeCount")]
            [Validation(Required=false)]
            public int? LikeCount { get; set; }

            /// <summary>
            /// <para>Whether the current user has liked it</para>
            /// </summary>
            [NameInMap("Liked")]
            [Validation(Required=false)]
            public bool? Liked { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>Map of metadata for text segmentation.</para>
            /// <remarks>
            /// <para>In document-search-type knowledge bases, the <c>file_path</c> field in the metadata Map is meaningless. Do not use it in your business code.</para>
            /// </remarks>
            /// <remarks>
            /// <para>When retrieving a document-search-type knowledge base, if a segment contains an image, the image URL will be exposed through the <c>image_url</c> field in the metadata Map, along with a time-to-live (TTL).</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>Map of metadata for text segmentation.</para>
            /// <remarks>
            /// <para>In document-search-type knowledge bases, the <c>file_path</c> field in the metadata Map is meaningless. Do not use it in your business code.</para>
            /// </remarks>
            /// <remarks>
            /// <para>When retrieving a document-search-type knowledge base, if a segment contains an image, the image URL will be exposed through the <c>image_url</c> field in the metadata Map, along with a time-to-live (TTL).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;operations\&quot;:[{\&quot;operator\&quot;:\&quot;replace\&quot;,\&quot;oldMetaName\&quot;:\&quot;character2_add\&quot;,\&quot;newMetaType\&quot;:\&quot;varchar(2)\&quot;}]}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>Preview URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://preview-lyj.aliyuncs.com/preview/4825a3849c2e49e1b48804c7f90b766f?subSceneIds=807648">https://preview-lyj.aliyuncs.com/preview/4825a3849c2e49e1b48804c7f90b766f?subSceneIds=807648</a></para>
            /// </summary>
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// <para>Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BasicVersion</b>: Basic Edition.</description></item>
            /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition.<remarks>
            /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V2</para>
            /// </summary>
            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// <para>Edition Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.2</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <para>Share count</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ShareCount")]
            [Validation(Required=false)]
            public int? ShareCount { get; set; }

            /// <summary>
            /// <para>trial, draft, live, refunded, expired, released</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>7cc17da1-b670-4be7-a6b4-0b3cdf7bf5f7</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Template Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>siemProtect_All_</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>application thumbnail</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("ThumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// <para>View count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ViewCount")]
            [Validation(Required=false)]
            public int? ViewCount { get; set; }

            /// <summary>
            /// <para>Hot word weight, an integer in the range [1, 5].<br>Common value: 4.<br>If the effect is not obvious, you can moderately increase the weight. However, if the weight is too high, it may cause negative effects and reduce the accuracy of detecting other words.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

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
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
