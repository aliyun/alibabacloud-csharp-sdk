// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaDetails : TeaModel {
        /// <summary>
        /// <para>Total MinQuota amount actually assigned</para>
        /// </summary>
        [NameInMap("ActualMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount ActualMinQuota { get; set; }

        /// <summary>
        /// <para>Quota amount assignable by the User</para>
        /// </summary>
        [NameInMap("AllocatableQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatableQuota { get; set; }

        /// <summary>
        /// <para>Total Quota usage information</para>
        /// </summary>
        [NameInMap("AllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatedQuota { get; set; }

        /// <summary>
        /// <para>Quota usage information of ancestors</para>
        /// </summary>
        [NameInMap("AncestorsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AncestorsAllocatedQuota { get; set; }

        /// <summary>
        /// <para>Quota usage information of descendants</para>
        /// </summary>
        [NameInMap("DescendantsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount DescendantsAllocatedQuota { get; set; }

        /// <summary>
        /// <para>Total MinQuota amount requested by the User</para>
        /// </summary>
        [NameInMap("DesiredMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount DesiredMinQuota { get; set; }

        [NameInMap("NodeStatistics")]
        [Validation(Required=false)]
        public QuotaNodeStatistics NodeStatistics { get; set; }

        /// <summary>
        /// <para>Quota request amount</para>
        /// </summary>
        [NameInMap("RequestedQuota")]
        [Validation(Required=false)]
        public ResourceAmount RequestedQuota { get; set; }

        /// <summary>
        /// <para>Quota usage information at the current level</para>
        /// </summary>
        [NameInMap("SelfAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfAllocatedQuota { get; set; }

        [NameInMap("SelfSubmittedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfSubmittedQuota { get; set; }

        /// <summary>
        /// <para>System-reserved Quota amount</para>
        /// </summary>
        [NameInMap("SystemReservedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SystemReservedQuota { get; set; }

        /// <summary>
        /// <para>Quota usage amount</para>
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public ResourceAmount UsedQuota { get; set; }

    }

}
