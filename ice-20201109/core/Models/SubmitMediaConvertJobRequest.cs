// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaConvertJobRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency key that is used to ensure repeated requests have the same effect as a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86f8e525-9d73-4dac-88aa-7aa4e950c00a</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of the transcoding task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e197ecfb103e4849922b054d3032f954</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;videoId&quot;:&quot;abcd&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
