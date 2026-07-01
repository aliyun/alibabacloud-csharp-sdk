// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateResponseBody : TeaModel {
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
        /// <para>The template information.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetTemplateResponseBodyTemplate Template { get; set; }
        public class GetTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The clip parameters for submitting a video production job. You can replace mediaId and text with real values to submit a job. References:</para>
            /// <list type="bullet">
            /// <item><description><para><a href="https://help.aliyun.com/document_detail/445399.html">Create and use a regular template</a></para>
            /// </description></item>
            /// <item><description><para><a href="https://help.aliyun.com/document_detail/445389.html">Create and use advanced templates</a></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Media1&quot;:&quot;mediaId&quot;,&quot;Text1&quot;:&quot;text&quot;}</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The template configurations.</para>
            /// <list type="bullet">
            /// <item><description><para>For more information about the configurations of a regular template, see <a href="https://help.aliyun.com/document_detail/456193.html">Config object of a regular template</a>.</para>
            /// </description></item>
            /// <item><description><para>For more information about the configurations of an advanced template, see <a href="https://help.aliyun.com/document_detail/445389.html">Create and use advanced templates</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>See Timeline template configuration details.</para>
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
            /// <para>The source from which the template was created. Valid values:</para>
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
            /// <para>The source from which the template was modified. Valid values:</para>
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
            /// <para>Video watermark template</para>
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
            /// <para>The state of the preview media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Init: the initial state, which indicates that the source file is not ready.</para>
            /// </description></item>
            /// <item><description><para>Preparing: The source file is being prepared. For example, the file is being uploaded or edited.</para>
            /// </description></item>
            /// <item><description><para>PrepareFail: The source file failed to be prepared. For example, the information about the source file failed to be obtained.</para>
            /// </description></item>
            /// <item><description><para>Normal: The source file is ready.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("PreviewMediaStatus")]
            [Validation(Required=false)]
            public string PreviewMediaStatus { get; set; }

            /// <summary>
            /// <para>The IDs of the materials associated with the template for use by the regular template editor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;video&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;],&quot;audio&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;],&quot;image&quot;:[&quot;<b><b><b>c04f1d4a06996144cc1a</b></b></b>&quot;]}</para>
            /// </summary>
            [NameInMap("RelatedMediaids")]
            [Validation(Required=false)]
            public string RelatedMediaids { get; set; }

            /// <summary>
            /// <para>The template state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Available</para>
            /// </description></item>
            /// <item><description><para>Created</para>
            /// </description></item>
            /// <item><description><para>Uploading</para>
            /// </description></item>
            /// <item><description><para>Processing</para>
            /// </description></item>
            /// <item><description><para>UploadFailed</para>
            /// </description></item>
            /// <item><description><para>ProcessFailed</para>
            /// </description></item>
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
            /// <para>The template type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Timeline</para>
            /// </description></item>
            /// <item><description><para>VETemplate</para>
            /// </description></item>
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
