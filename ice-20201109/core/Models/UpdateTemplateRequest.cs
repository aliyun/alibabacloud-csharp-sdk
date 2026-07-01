// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template configurations. For more information, see <a href="https://help.aliyun.com/document_detail/456193.html">Config object of a regular template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;VideoTracks&quot;: [
        ///         {
        ///             &quot;VideoTrackClips&quot;: [
        ///                 {
        ///                     &quot;Sys_Type&quot; : &quot;ArrayItems&quot;,
        ///                     &quot;Sys_ArrayObject&quot; : &quot;$VideoArray&quot;,
        ///                     &quot;Sys_Template&quot; : {
        ///                         &quot;MediaId&quot; : &quot;$MediaId&quot;
        ///                     }
        ///                 }
        ///             ]
        ///         }
        ///     ]
        /// }</para>
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
        /// <para>Cloud editing template 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the preview video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae320b48fb04483915d4f2cd8ac****</para>
        /// </summary>
        [NameInMap("PreviewMedia")]
        [Validation(Required=false)]
        public string PreviewMedia { get; set; }

        /// <summary>
        /// <para>The IDs of the materials associated with the template for use by the regular template editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:[&quot;f64c6acc840247edb6b12f575c66****&quot;,&quot;9675dcf040ba4525bb037c29d156****&quot;],&quot;audio&quot;:[&quot;62a54019d9114009a5ae9bcfd70b****&quot;],&quot;image&quot;:[&quot;743ffbeb7e004c758cdc1fb34c04****&quot;]}</para>
        /// </summary>
        [NameInMap("RelatedMediaids")]
        [Validation(Required=false)]
        public string RelatedMediaids { get; set; }

        /// <summary>
        /// <para>The source from which the template is modified. Default value: OpenAPI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AliyunConsole</para>
        /// </description></item>
        /// <item><description><para>OpenAPI</para>
        /// </description></item>
        /// <item><description><para>WebSDK</para>
        /// </description></item>
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
        /// <item><description><para>Available: The template is available.</para>
        /// </description></item>
        /// <item><description><para>Created: The template is created but not ready for use.</para>
        /// </description></item>
        /// <item><description><para>Uploading: The video is being uploaded.</para>
        /// </description></item>
        /// <item><description><para>Processing: The advanced template is being processed.</para>
        /// </description></item>
        /// <item><description><para>UploadFailed: Failed to upload the video.</para>
        /// </description></item>
        /// <item><description><para>ProcessFailed: Failed to process the advanced template.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After an advanced template is created, it enters the Processing state. In this case, the template is unavailable. The template can be used only when it is in the Available state. The time required for template processing varies based on the size of the template file. Generally, it ranges from 10 seconds to 5 minutes.</para>
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
        /// <para>23923ec3318f4c359e42e1e5b296****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
