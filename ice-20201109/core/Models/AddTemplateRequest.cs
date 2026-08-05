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
        /// <item><description>The standard template Config is an encapsulation based on the cloud editing Timeline. Custom template Config provides more flexibility. If you have special requirements, familiarize yourself with the Config structure and customize the template. For details, see <a href="https://help.aliyun.com/document_detail/456193.html">Standard template Config details</a>.</description></item>
        /// <item><description>For more template Config examples, see <a href="https://help.aliyun.com/document_detail/451634.html">Common standard template Config examples</a>.</description></item>
        /// <item><description>For one-click video production template Config configurations, see <a href="https://help.aliyun.com/document_detail/2878274.html">One-click video production template configuration parameter description</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>See the Timeline template Config documentation</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The template cover URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg">http://example-bucket.oss-cn-shanghai.aliyuncs.com/cover.jpg</a></para>
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <para>The custom template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The media asset ID of the template preview video.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>01bf24bf41c78b2754cb3187</b></b></para>
        /// </summary>
        [NameInMap("PreviewMedia")]
        [Validation(Required=false)]
        public string PreviewMedia { get; set; }

        /// <summary>
        /// <para>The media assets associated with the template, used by the standard template editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:[&quot;1805a0c6ca544fb395a06ca683619655&quot;]}</para>
        /// </summary>
        [NameInMap("RelatedMediaids")]
        [Validation(Required=false)]
        public string RelatedMediaids { get; set; }

        /// <summary>
        /// <para>The template creation source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OpenAPI: created by using OpenAPI.</description></item>
        /// <item><description>AliyunConsole: created by using the Alibaba Cloud Management Console.</description></item>
        /// <item><description>WebSDK: created by using WebSDK.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The template status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: normal.</description></item>
        /// <item><description>Created: created but not yet available.</description></item>
        /// <item><description>Uploading: uploading.</description></item>
        /// <item><description>Processing: advanced template is being analyzed.</description></item>
        /// <item><description>UploadFailed: upload failed.</description></item>
        /// <item><description>ProcessFailed: advanced template analysis failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The templatetype. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>Timeline (standard template): a template created based on the Timeline of a video clip node (multiple materials on multiple tracks are concatenated in sequence). This templatetype can be used to implement effects such as image-to-video conversion, photo albums, intros and outros, and default watermarks.</description></item>
        /// <item><description>VETemplate (advanced template): a template created based on Adobe After Effects (AE) effects. This templatetype can be used to implement advanced media effects with complex animations.</description></item>
        /// <item><description>BatchEditing (one-click video production template): supports configurations for sticker watermarks, background music, background images, narration subtitle styles, title subtitle styles, and output resolution parameters. These configurations are automatically applied when you commit a one-click video production node.</description></item>
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
