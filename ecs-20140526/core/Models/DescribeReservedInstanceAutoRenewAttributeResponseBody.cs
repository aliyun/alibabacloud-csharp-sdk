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

        /// <summary>
        /// <para>Details about the auto-renewal settings of the reserved instances.</para>
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
                /// <para>The auto-renewal duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal duration.</para>
                /// <para>Valid values: Year and Month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The auto-renewal status of the reserved instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: The reserved instance is automatically renewed.</description></item>
                /// <item><description>Normal: You must manually renew the reserved instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AutoRenewal</para>
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

                /// <summary>
                /// <para>The ID of the reserved instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecsri-ajdfaj****</para>
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

            }

        }

    }

}
