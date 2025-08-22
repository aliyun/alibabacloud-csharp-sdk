// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaDetails : TeaModel {
        [NameInMap("ActualMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount ActualMinQuota { get; set; }

        [NameInMap("AllocatableQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatableQuota { get; set; }

        [NameInMap("AllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AllocatedQuota { get; set; }

        [NameInMap("AncestorsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount AncestorsAllocatedQuota { get; set; }

        [NameInMap("DescendantsAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount DescendantsAllocatedQuota { get; set; }

        [NameInMap("DesiredMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount DesiredMinQuota { get; set; }

        [NameInMap("RequestedQuota")]
        [Validation(Required=false)]
        public ResourceAmount RequestedQuota { get; set; }

        [NameInMap("SelfAllocatedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfAllocatedQuota { get; set; }

        [NameInMap("SelfSubmittedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SelfSubmittedQuota { get; set; }

        [NameInMap("SystemReservedQuota")]
        [Validation(Required=false)]
        public ResourceAmount SystemReservedQuota { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public ResourceAmount UsedQuota { get; set; }

    }

}
