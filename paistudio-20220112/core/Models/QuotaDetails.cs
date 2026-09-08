// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaDetails : TeaModel {
        /// <summary>
        /// <para>The total MinQuota actually allocated. For example, if the user configured 10 nodes but only 8 nodes are actually bound, this value returns the total resources of the 8 nodes.</para>
        /// </summary>
        [NameInMap("ActualMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount ActualMinQuota { get; set; }

        /// <summary>
        /// <para>The user-allocatable quota amount. For general computing resources, each node has system-reserved resources. This value represents the quota resources that user workloads can occupy.
        /// ActualMin = AllocatableQuota + SystemReservedQuota.</para>
        /// </summary>
        [NameInMap("AllocatableQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatableQuota { get; set; }

        /// <summary>
        /// <para>The total quota usage information, which is the total resources occupied by workloads after scheduling to nodes.</para>
        /// </summary>
        [NameInMap("AllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatedQuota { get; set; }

        /// <summary>
        /// <para>The ancestor quota usage information, which is the total resources of workloads submitted using ancestor quotas after they are scheduled to nodes.</para>
        /// </summary>
        [NameInMap("AncestorsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AncestorsAllocatedQuota { get; set; }

        /// <summary>
        /// <para>The descendant quota usage information, which is the total resources of workloads submitted using descendant quotas after they are scheduled to nodes.</para>
        /// </summary>
        [NameInMap("DescendantsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount DescendantsAllocatedQuota { get; set; }

        /// <summary>
        /// <para>The total MinQuota desired by the user.</para>
        /// </summary>
        [NameInMap("DesiredMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount DesiredMinQuota { get; set; }

        /// <summary>
        /// <para>The statistics information of nodes within the quota.</para>
        /// </summary>
        [NameInMap("NodeStatistics")]
        [Validation(Required=false)]
        public QuotaNodeStatistics NodeStatistics { get; set; }

        /// <summary>
        /// <para>The quota requested amount, which is the total resources occupied by workloads after they are dequeued.</para>
        /// </summary>
        [NameInMap("RequestedQuota")]
        [Validation(Required=false)]
        public ResourceAmount RequestedQuota { get; set; }

        /// <summary>
        /// <para>The current-level quota usage information, which is the total resources of workloads submitted using this quota after they are scheduled to nodes.</para>
        /// </summary>
        [NameInMap("SelfAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfAllocatedQuota { get; set; }

        /// <summary>
        /// <para>The amount submitted to this quota, which is the total resources of workloads submitted to this quota, including workloads that are queued.</para>
        /// </summary>
        [NameInMap("SelfSubmittedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfSubmittedQuota { get; set; }

        /// <summary>
        /// <para>The system-reserved quota amount.</para>
        /// </summary>
        [NameInMap("SystemReservedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SystemReservedQuota { get; set; }

        /// <summary>
        /// <para>The quota used amount. This field is deprecating. Use AllocatedQuota instead.</para>
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public ResourceAmount UsedQuota { get; set; }

    }

}
