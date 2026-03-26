// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        [NameInMap("DedicatedHostRenewAttributes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes DedicatedHostRenewAttributes { get; set; }
        public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes : TeaModel {
            [NameInMap("DedicatedHostRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute> DedicatedHostRenewAttribute { get; set; }
            public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute : TeaModel {
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                [NameInMap("AutoRenewWithEcs")]
                [Validation(Required=false)]
                public string AutoRenewWithEcs { get; set; }

                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
