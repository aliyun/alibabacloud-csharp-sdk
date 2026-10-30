// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The configuration details of the aggregate route.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTransitRouteTableAggregationDetailResponseBodyData> Data { get; set; }
        public class DescribeTransitRouteTableAggregationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message returned when the aggregate route configuration fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC-connected instance to which the aggregation routing is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-6eh7fp9hdqa2wv85t****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configuration status of the aggregate route.</para>
            /// <list type="bullet">
            /// <item><description><b>Configured</b>: The aggregate route is delivered to the VPC-connected instance.</description></item>
            /// <item><description><b>Configuring</b>: The aggregate route is being delivered.</description></item>
            /// <item><description><b>ConfigFailed</b>: The aggregate route fails to be delivered.</description></item>
            /// <item><description><b>PartialConfigured</b>: The aggregate route is partially delivered.</description></item>
            /// <item><description><b>Deleting</b>: The aggregate route is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Configured</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C2EE7A8-74D4-4081-8236-CEBDE3BBCF50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
