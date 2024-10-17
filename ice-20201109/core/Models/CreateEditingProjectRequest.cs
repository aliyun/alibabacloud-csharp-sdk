// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The business configuration of the project. This parameter can be ignored for general editing projects.</para>
        /// <para>For a live stream editing project, observe the following rules: OutputMediaConfig.StorageLocation is required. OutputMediaConfig.Path is optional. If you do not specify this option, the live streaming clips are stored in the root directory by default.</para>
        /// <para>Valid values of OutputMediaTarget include vod-media and oss-object. If you do not specify OutputMediaTarget, the default value oss-object is used.</para>
        /// <para>If you set OutputMediaTarget to vod-media, the setting of OutputMediaConfig.Path does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;OutputMediaConfig&quot; : { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot; }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
        /// </summary>
        [NameInMap("BusinessConfig")]
        [Validation(Required=false)]
        public string BusinessConfig { get; set; }

        /// <summary>
        /// <para>The material parameter corresponding to the template, in the JSON format. If TemplateId is specified, ClipsParam must also be specified. For more information&lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/document_detail/328557.html">Create and use a regular template</a> and <a href="https://help.aliyun.com/document_detail/291418.html">Create and use an advanced template</a>.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The thumbnail URL of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.png">https://example.com/example.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The material associated with the project. Separate multiple material IDs with commas (,). Each type supports up to 10 material IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:&quot;<em><b><b>2e057304fcd9b145c5cafc</b></b></em>&quot;, &quot;image&quot;:&quot;<b><b>8021a8d493da643c8acd98</b></b>*,<em><b><b>cb6307a4edea614d8b3f3c</b></b></em>&quot;, &quot;liveStream&quot;: &quot;[{\&quot;appName\&quot;:\&quot;testrecord\&quot;,\&quot;domainName\&quot;:\&quot;test.alivecdn.com\&quot;,\&quot;liveUrl\&quot;:\&quot;rtmp://test.alivecdn.com/testrecord/teststream\&quot;,\&quot;streamName\&quot;:\&quot;teststream\&quot;}]&quot;, &quot;editingProject&quot;: &quot;<em><b><b>9b145c5cafc2e057304fcd</b></b></em>&quot;}</para>
        /// </summary>
        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        /// <summary>
        /// <para>The type of the editing project. Valid values: EditingProject and LiveEditingProject. A value of EditingProject indicates a regular editing project, and a value of LiveEditingProject indicates a live stream editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LiveEditingProject</para>
        /// </summary>
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter is used to quickly build a timeline with ease. Note: Only one of Timeline and TemplateId can be specified. If TemplateId is specified, ClipsParam must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The template type. This parameter is required if you create a template-based online editing project. Default value: Timeline. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Timeline: a regular template.</description></item>
        /// <item><description>VETemplate: an advanced template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Timeline</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
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
