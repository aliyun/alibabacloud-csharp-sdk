// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ScheduledPlan : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1723197248</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1723197248</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-scheduled-plan</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER_DEFINED</para>
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("periodicSchedulingPolicies")]
        [Validation(Required=false)]
        public List<PeriodicSchedulingPolicy> PeriodicSchedulingPolicies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f3b4ec1e-85dc-4b1d-9726-1d7f4c37****</para>
        /// </summary>
        [NameInMap("scheduledPlanId")]
        [Validation(Required=false)]
        public string ScheduledPlanId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("updatedByUser")]
        [Validation(Required=false)]
        public bool? UpdatedByUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
