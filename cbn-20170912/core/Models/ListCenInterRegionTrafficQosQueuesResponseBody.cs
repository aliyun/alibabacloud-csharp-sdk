// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0151fa6aa1ed****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D1E15D2-416D-54F3-BDD9-BC27DE4C6352</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queue information of the traffic scheduling policy.</para>
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues> TrafficQosQueues { get; set; }
        public class ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues : TeaModel {
            /// <summary>
            /// <para>The inter-region bandwidth allocated to the current queue when the bandwidth guarantee type is set to absolute value mode.</para>
            /// <para>For example, a value of <b>1</b> indicates that traffic packets matching the current queue can use up to 1 Mbit/s of inter-region bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The DSCP values matched by the current queue.</para>
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// <para>The actual effective bandwidth value of the current queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.35</para>
            /// </summary>
            [NameInMap("EffectiveBandwidth")]
            [Validation(Required=false)]
            public string EffectiveBandwidth { get; set; }

            /// <summary>
            /// <para>The percentage of inter-region bandwidth that the current queue can use when the bandwidth guarantee type is set to percentage mode.</para>
            /// <para>For example, a value of <b>1</b> indicates that traffic packets matching the current queue can use up to 1% of the inter-region bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public int? RemainBandwidthPercent { get; set; }

            /// <summary>
            /// <para>The status of the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The queue is being created.</description></item>
            /// <item><description><b>Active</b>: The queue is running.</description></item>
            /// <item><description><b>Deleting</b>: The queue is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the traffic scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-fv2qq9yqrsjowp****</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            /// <summary>
            /// <para>The description of the traffic scheduling policy queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qosQueueDescription</para>
            /// </summary>
            [NameInMap("TrafficQosQueueDescription")]
            [Validation(Required=false)]
            public string TrafficQosQueueDescription { get; set; }

            /// <summary>
            /// <para>The ID of the traffic scheduling policy queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-siakjb2nn9gz5z****</para>
            /// </summary>
            [NameInMap("TrafficQosQueueId")]
            [Validation(Required=false)]
            public string TrafficQosQueueId { get; set; }

            /// <summary>
            /// <para>The name of the traffic scheduling policy queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qosQueueName</para>
            /// </summary>
            [NameInMap("TrafficQosQueueName")]
            [Validation(Required=false)]
            public string TrafficQosQueueName { get; set; }

            /// <summary>
            /// <para>The ID of the inter-region connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-nzrcv25d7ezt23****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The ID of the transit router instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-p0wwagjv6fvxt4b7y****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
