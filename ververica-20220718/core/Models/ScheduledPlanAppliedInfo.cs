// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ScheduledPlanAppliedInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("expectedState")]
        [Validation(Required=false)]
        public string ExpectedState { get; set; }

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
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f3b4ec1e-85dc-4b1d-9726-1d7f4c37****</para>
        /// </summary>
        [NameInMap("scheduledPlanId")]
        [Validation(Required=false)]
        public string ScheduledPlanId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-scheduled-plan</para>
        /// </summary>
        [NameInMap("scheduledPlanName")]
        [Validation(Required=false)]
        public string ScheduledPlanName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WAITING</para>
        /// </summary>
        [NameInMap("statusState")]
        [Validation(Required=false)]
        public string StatusState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
