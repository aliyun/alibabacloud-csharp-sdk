// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateOptimizeRunRequest : TeaModel {
        /// <summary>
        /// <para>The JSON input defined by the task type, preserving the original object or array structure. ExperienceMining accepts a start/end/processTimeMaxNS object. SkillOptimize accepts an inline input array, a skills/window object for SLS, or a skills/records object for ATIF or xTrace. The server validates the input based on the task type and configuration. Memory extraction continues to use the original ContextStore API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start&quot;:1727136000,&quot;end&quot;:1727139600,&quot;processTimeMaxNS&quot;:1727139600000000000}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public object Input { get; set; }

        /// <summary>
        /// <para>Specifies whether to execute an independent pre-run of the complete algorithm. The pre-run generates candidate results and evidence without publishing them to the target dataset or advancing the formal run history. A formal run executes the algorithm independently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("preview")]
        [Validation(Required=false)]
        public bool? Preview { get; set; }

        /// <summary>
        /// <para>The idempotency token. Use the same value when you retry the same creation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
