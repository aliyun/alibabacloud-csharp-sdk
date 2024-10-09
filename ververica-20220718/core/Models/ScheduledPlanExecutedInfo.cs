// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ScheduledPlanExecutedInfo : TeaModel {
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
        /// <para>0e6d3bab-2277-4ed1-b573-9de6413d****</para>
        /// </summary>
        [NameInMap("jobResourceUpgradingId")]
        [Validation(Required=false)]
        public string JobResourceUpgradingId { get; set; }

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
        /// <para>SCHEDULED_PLAN</para>
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f8a2d5d9-9fc5-4273-bfcc-2a3cd354****</para>
        /// </summary>
        [NameInMap("originJobId")]
        [Validation(Required=false)]
        public string OriginJobId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public ScheduledPlanExecutedStatus Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
