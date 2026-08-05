// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The business configuration of the project. This parameter can be ignored for standard editing projects.</para>
        /// <list type="bullet">
        /// <item><description><para>For live editing projects, OutputMediaConfig.StorageLocation is required.</para>
        /// </description></item>
        /// <item><description><para>If OutputMediaConfig.Path is not specified, the produced live clips are stored in the root path by default. </para>
        /// </description></item>
        /// <item><description><para>OutputMediaTarget can be set to vod-media or oss-object. Default value: oss-object.</para>
        /// </description></item>
        /// <item><description><para>When OutputMediaTarget is set to vod-media, Path does not take effect.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;OutputMediaConfig&quot; : { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot; }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
        /// </summary>
        [NameInMap("BusinessConfig")]
        [Validation(Required=false)]
        public string BusinessConfig { get; set; }

        /// <summary>
        /// <para>The material parameters corresponding to the template in JSON format. If TemplateId is specified, ClipsParam must also be specified. For more information about the format, see <a href="https://help.aliyun.com/document_detail/445399.html">Create and use a standard template</a> and <a href="https://help.aliyun.com/document_detail/445389.html">Create and use an advanced template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>See the template user guide.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The cover URL of the cloud editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.png">https://example.com/example.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the cloud editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The materials associated with the project. Separate multiple materials with commas (,). A maximum of 10 material IDs are supported for each type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:&quot;<em><b><b>2e057304fcd9b145c5cafc</b></b></em>&quot;, &quot;image&quot;:&quot;<b><b>8021a8d493da643c8acd98</b></b>*,<em><b><b>cb6307a4edea614d8b3f3c</b></b></em>&quot;, &quot;liveStream&quot;: &quot;[{\&quot;appName\&quot;:\&quot;testrecord\&quot;,\&quot;domainName\&quot;:\&quot;test.alivecdn.com\&quot;,\&quot;liveUrl\&quot;:\&quot;rtmp://test.alivecdn.com/testrecord/teststream\&quot;,\&quot;streamName\&quot;:\&quot;teststream\&quot;}]&quot;, &quot;editingProject&quot;: &quot;<em><b><b>9b145c5cafc2e057304fcd</b></b></em>&quot;}</para>
        /// </summary>
        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        /// <summary>
        /// <para>The type of the editing project.</para>
        /// <list type="bullet">
        /// <item><description><para>EditingProject: standard editing project.</para>
        /// </description></item>
        /// <item><description><para>LiveEditingProject: live editing project.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LiveEditingProject</para>
        /// </summary>
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        /// <summary>
        /// <para>The template ID, which is used to quickly build a timeline with minimal effort.</para>
        /// <remarks>
        /// <para>Notice: Either Timeline or TemplateId must be specified, but not both. If TemplateId is specified, ClipsParam must also be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The templatetype. Specify this parameter when you create a template-based cloud editing project. Default value: Timeline.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Timeline: standard template.</description></item>
        /// <item><description>VETemplate: advanced template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Timeline</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The timeline of the cloud editing project in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the cloud editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
