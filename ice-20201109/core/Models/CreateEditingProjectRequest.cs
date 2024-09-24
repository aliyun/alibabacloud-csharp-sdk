// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;OutputMediaConfig&quot; : { &quot;StorageLocation&quot;: &quot;test-bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;Path&quot;: &quot;test-path&quot; }, &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;, &quot;ReservationTime&quot;: &quot;2021-06-21T08:05:00Z&quot; }</para>
        /// </summary>
        [NameInMap("BusinessConfig")]
        [Validation(Required=false)]
        public string BusinessConfig { get; set; }

        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.png">https://example.com/example.png</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:&quot;<em><b><b>2e057304fcd9b145c5cafc</b></b></em>&quot;, &quot;image&quot;:&quot;<b><b>8021a8d493da643c8acd98</b></b>*,<em><b><b>cb6307a4edea614d8b3f3c</b></b></em>&quot;, &quot;liveStream&quot;: &quot;[{\&quot;appName\&quot;:\&quot;testrecord\&quot;,\&quot;domainName\&quot;:\&quot;test.alivecdn.com\&quot;,\&quot;liveUrl\&quot;:\&quot;rtmp://test.alivecdn.com/testrecord/teststream\&quot;,\&quot;streamName\&quot;:\&quot;teststream\&quot;}]&quot;, &quot;editingProject&quot;: &quot;<em><b><b>9b145c5cafc2e057304fcd</b></b></em>&quot;}</para>
        /// </summary>
        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LiveEditingProject</para>
        /// </summary>
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

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
