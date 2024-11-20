// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The template information.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public AddTemplateResponseBodyTemplate Template { get; set; }
        public class AddTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The template configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>参见Timeline模板Config文档</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The URL of the template thumbnail.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg">http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg</a></para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

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
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频添加水印模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the preview video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
            /// </summary>
            [NameInMap("PreviewMedia")]
            [Validation(Required=false)]
            public string PreviewMedia { get; set; }

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
            /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
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

    }

}
