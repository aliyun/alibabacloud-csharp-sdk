// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether a retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ish-intelligence-store-platform-admin-web</para>
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
        /// <para>The dynamic error message, which is used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the value of the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
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
        /// <para>Indicates whether the deletion was successful.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppTemplateResponseBodyModule Module { get; set; }
        public class GetAppTemplateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The business ID.</para>
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
            /// <para>The actual amount of data copied from the original table during a DMS lock-free schema change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CopyCount")]
            [Validation(Required=false)]
            public int? CopyCount { get; set; }

            /// <summary>
            /// <para>The user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>208614160512124381</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creation time in UTC. The date format follows ISO 8601.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-04T01:40:25Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The modification time in ISO 8601 format. The time zone is UTC (Z).</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-05T11:16:57.785Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The industry. Default value: <b>common</b> (general industry). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>microVideo</b>: short video industry.</para>
            /// </description></item>
            /// <item><description><para><b>common</b>: general industry.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>The industry name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>indextry</para>
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>The last modifier.</para>
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
            /// <para>Indicates whether the current user has liked the template.</para>
            /// </summary>
            [NameInMap("Liked")]
            [Validation(Required=false)]
            public bool? Liked { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The metadata map of the text chunk.</para>
            /// <remarks>
            /// <para>The <c>file_path</c> field in the metadata map of a document search knowledge base is meaningless. Do not use it in your business code.</para>
            /// </remarks>
            /// <remarks>
            /// <para>When retrieving a document search knowledge base, if a chunk contains images, the image URL is returned in the <c>image_url</c> field of the metadata map, along with an expiration time.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>The metadata map of the text chunk.</para>
            /// <remarks>
            /// <para>The <c>file_path</c> field in the metadata map of a document search knowledge base is meaningless. Do not use it in your business code.</para>
            /// </remarks>
            /// <remarks>
            /// <para>When retrieving a document search knowledge base, if a chunk contains images, the image URL is returned in the <c>image_url</c> field of the metadata map, along with an expiration time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;operations\&quot;:[{\&quot;operator\&quot;:\&quot;replace\&quot;,\&quot;oldMetaName\&quot;:\&quot;character2_add\&quot;,\&quot;newMetaType\&quot;:\&quot;varchar(2)\&quot;}]}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The preview URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://preview-lyj.aliyuncs.com/preview/4825a3849c2e49e1b48804c7f90b766f?subSceneIds=807648">https://preview-lyj.aliyuncs.com/preview/4825a3849c2e49e1b48804c7f90b766f?subSceneIds=807648</a></para>
            /// </summary>
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// <para>The product version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BasicVersion</b>: Basic edition.</description></item>
            /// <item><description><b>EnterpriseVersion</b>: Enterprise edition.<remarks>
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
            /// <para>trial,draft,live,refunded,expired,released</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7cc17da1-b670-4be7-a6b4-0b3cdf7bf5f7</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>siemProtect_All_</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The application thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
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
            /// <para>The weight of the hot word. Valid values: integers in the range of [1, 5].
            /// Common value: 4.
            /// If the effect is not obvious, increase the weight as needed. However, an excessively large weight may cause negative effects and lead to inaccurate recognition of other words.</para>
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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The root error message.</para>
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
