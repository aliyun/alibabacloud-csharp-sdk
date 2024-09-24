// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        [NameInMap("EditingProduceConfig")]
        [Validation(Required=false)]
        public string EditingProduceConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Title&quot;:&quot;test-title&quot;,
        ///       &quot;Tags&quot;:&quot;test-tags1,tags2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4%22%7D">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxfb2101cb318xxxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectMetadata")]
        [Validation(Required=false)]
        public string ProjectMetadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPENAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
