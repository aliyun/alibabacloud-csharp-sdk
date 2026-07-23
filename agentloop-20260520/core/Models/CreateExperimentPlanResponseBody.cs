// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateExperimentPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Experiment plan created successfully.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The experiment plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-plan-e95bff54685a4ae29ff3a834c1008a71</para>
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
        /// <para>The creation result. The value is <c>created</c> if the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>created</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
