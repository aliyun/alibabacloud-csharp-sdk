// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The clip parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Media1&quot;:&quot;mediaId&quot;,&quot;Text1&quot;:&quot;text&quot;}</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The template configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>参考Timeline模板配置详解</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg">http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The source from which the template was created.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AliyunConsole</description></item>
            /// <item><description>WebSDK</description></item>
            /// <item><description>OpenAPI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI</para>
            /// </summary>
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The source from which the template was modified.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AliyunConsole</description></item>
            /// <item><description>WebSDK</description></item>
            /// <item><description>OpenAPI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI</para>
            /// </summary>
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-26T04:11:10Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频添加水印模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The preview media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("PreviewMedia")]
            [Validation(Required=false)]
            public string PreviewMedia { get; set; }

            /// <summary>
            /// <para>The state of the preview media asset.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrepareFail</description></item>
            /// <item><description>Init</description></item>
            /// <item><description>Normal</description></item>
            /// <item><description>Preparing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("PreviewMediaStatus")]
            [Validation(Required=false)]
            public string PreviewMediaStatus { get; set; }

            /// <summary>
            /// <para>The template state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UploadFailed: Failed to upload the video.</description></item>
            /// <item><description>ProcessFailed: Failed to process the advanced template.</description></item>
            /// <item><description>Available: The template is available.</description></item>
            /// <item><description>Uploading: The video is being uploaded.</description></item>
            /// <item><description>Created: The template is created but not ready for use.</description></item>
            /// <item><description>Processing: The advanced template is being processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Timeline: regular template.</description></item>
            /// <item><description>VETemplate: advanced template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Timeline</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
