// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteExperimentPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The experiment plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-plan-aa1a66b074bc42aa8696c73c7dc9b718</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The deletion result. The value is deleted if the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deleted</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
