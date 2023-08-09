// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstanceAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the auto-renewal settings of the reserved instances.
        /// </summary>
        [NameInMap("ReservedInstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributes ReservedInstanceRenewAttributes { get; set; }
        public class DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributes : TeaModel {
            [NameInMap("ReservedInstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributesReservedInstanceRenewAttribute> ReservedInstanceRenewAttribute { get; set; }
            public class DescribeReservedInstanceAutoRenewAttributeResponseBodyReservedInstanceRenewAttributesReservedInstanceRenewAttribute : TeaModel {
                /// <summary>
                /// The auto-renewal duration.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The unit of the auto-renewal duration.
                /// 
                /// Valid values: Year and Month.
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// The auto-renewal status of the reserved instance. Valid values:
                /// 
                /// *   AutoRenewal: The reserved instance is automatically renewed.
                /// *   Normal: You must manually renew the reserved instance.
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

                /// <summary>
                /// The ID of the reserved instance.
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

            }

        }

    }

}
