// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstanceAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservedInstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributes ReservedInstanceRenewAttributes { get; set; }
        public class DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributes : TeaModel {
            [NameInMap("ReservedInstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributesReservedInstanceRenewAttribute> ReservedInstanceRenewAttribute { get; set; }
            public class DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributesReservedInstanceRenewAttribute : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

            }

        }

    }

}
