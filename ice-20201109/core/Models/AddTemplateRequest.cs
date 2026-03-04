// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddTemplateRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The template configurations. The Config object of a regular template is encapsulated based on the Timeline object of an online editing project. The Config object of a custom template provides more flexible features. If you have special requirements, we recommend that you understand the structure of a Config object and configure a custom template. For more information, see <a href="https://help.aliyun.com/document_detail/456193.html">Config object of a regular template</a>.</description></item>
        /// <item><description>For more information about Config object examples, see <a href="https://help.aliyun.com/document_detail/451634.html">Basic template configurations</a>.</description></item>
        /// </list>
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
        /// <para>The name of the custom template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>视频添加水印模板</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the template preview video.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
        /// </summary>
        [NameInMap("PreviewMedia")]
        [Validation(Required=false)]
        public string PreviewMedia { get; set; }

        /// <summary>
        /// <para>The IDs of the materials associated with the template for use by the regular template editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:[&quot;1805a0c6ca544fb395a06ca683619655&quot;]}</para>
        /// </summary>
        [NameInMap("RelatedMediaids")]
        [Validation(Required=false)]
        public string RelatedMediaids { get; set; }

        /// <summary>
        /// <para>The source from which the template is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OpenAPI</description></item>
        /// <item><description>AliyunConsole</description></item>
        /// <item><description>WebSDK</description></item>
        /// </list>
        /// <!---->
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
        /// <!---->
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The template type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Timeline: a regular template created based on the timeline of a video editing project, in which multiple materials are arranged in sequence across multiple layers. It can be used to convert text and images into videos, create photo albums, add opening and closing parts, and apply the default watermark.</description></item>
        /// <item><description>VETemplate: an advanced template created using effects of Adobe After Effects (AE). It can be used to produce complex animations and advanced media effects.</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <b>Example:</b>
        /// <para>Timeline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
