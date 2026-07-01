// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaConvertJobRequest : TeaModel {
        /// <summary>
        /// <para>A unique client token that ensures request idempotency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86f8e525-9d73-4dac-88aa-7aa4e950c00a</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The transcoding job configuration. For more information, see <a href="https://help.aliyun.com/document_detail/2999539.html">MediaConvertJobConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the pipeline for the transcoding job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e197ecfb103e4849922b054d3032f954</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>Custom data to pass with the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;videoId&quot;:&quot;abcd&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
