// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAIAgentVideoAuditTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*<b><b><b>3b3d94abda22</b></b></b></para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The interval, in milliseconds, at which to submit captured frames to the AI agent. Valid values: 0 to 5000. Default value: 3000. If it is set to 0, all captured frames are sent to the model in a single batch request. Otherwise, frames are sent sequentially with the specified interval between each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("AuditInterval")]
        [Validation(Required=false)]
        public int? AuditInterval { get; set; }

        /// <summary>
        /// <para>Callback configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Url&quot;:&quot;<a href="https://yourcallback%22,%22Token%22:%22yourtoken%22%7D">https://yourcallback&quot;,&quot;Token&quot;:&quot;yourtoken&quot;}</a></para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfigShrink { get; set; }

        /// <summary>
        /// <para>An array of frame-capturing policies. Each policy defines a set of frames to be analyzed and will generate a separate result from the model.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CapturePolicies")]
        [Validation(Required=false)]
        public string CapturePoliciesShrink { get; set; }

        /// <summary>
        /// <para>The details of the input file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
