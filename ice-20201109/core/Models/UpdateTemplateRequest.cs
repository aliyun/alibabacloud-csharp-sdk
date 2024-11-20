// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>参见模板Config文档</para>
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
        /// <para>The name of the online editing template.</para>
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
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("PreviewMedia")]
        [Validation(Required=false)]
        public string PreviewMedia { get; set; }

        /// <summary>
        /// <para>The IDs of the materials associated with the template for use by the regular template editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;,&quot;<b><b><b>cb7db64841b159b4f2ea</b></b></b>&quot;],&quot;audio&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;],&quot;image&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;]}</para>
        /// </summary>
        [NameInMap("RelatedMediaids")]
        [Validation(Required=false)]
        public string RelatedMediaids { get; set; }

        /// <summary>
        /// <para>The source from which the template is modified. Default value: OpenAPI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AliyunConsole</description></item>
        /// <item><description>OpenAPI</description></item>
        /// <item><description>WebSDK</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The template state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: The template is available.</description></item>
        /// <item><description>Created: The template is created but not ready for use.</description></item>
        /// <item><description>Uploading: The video is being uploaded.</description></item>
        /// <item><description>Processing: The advanced template is being processed.</description></item>
        /// <item><description>UploadFailed: Failed to upload the video.</description></item>
        /// <item><description>ProcessFailed: Failed to process the advanced template.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After an advanced template is created, it enters the Processing state. In this case, the template is unavailable. The template can be used only when it is in the Available state. The time required for template processing varies based on the size of the template file. Generally, it ranges from 10 seconds to 5 minutes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the online editing template. You can obtain the template ID in the <a href="https://ice.console.aliyun.com/production/template/list/common">Intelligent Media Services (IMS) console</a> or the response parameters of the <a href="https://help.aliyun.com/document_detail/441161.html">AddTemplate</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
