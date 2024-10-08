// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeSpotDiscountHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The discount for the preemptible instance.</para>
        /// </summary>
        [NameInMap("SpotDiscounts")]
        [Validation(Required=false)]
        public List<DescribeSpotDiscountHistoryResponseBodySpotDiscounts> SpotDiscounts { get; set; }
        public class DescribeSpotDiscountHistoryResponseBodySpotDiscounts : TeaModel {
            /// <summary>
            /// <para>The type of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c7.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The discount for the preemptible instance. For example, 0.1 represents a 90% discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public string SpotDiscount { get; set; }

            /// <summary>
            /// <para>The time when the discount is available. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10T10:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
