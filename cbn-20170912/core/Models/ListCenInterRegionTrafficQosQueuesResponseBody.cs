// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0151fa6aa1ed****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D1E15D2-416D-54F3-BDD9-BC27DE4C6352</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the QoS queue.</para>
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues> TrafficQosQueues { get; set; }
        public class ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues : TeaModel {
            /// <summary>
            /// <para>带宽保障类型为按绝对值模式时，当前队列分配跨地域带宽的值。</para>
            /// <para>例如，<b>1</b>表示符合当前队列的流量报文最多只能使用1Mbps的跨地域带宽。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value that matches the current QoS queue.</para>
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// <para>当前队列实际生效的带宽值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.35</para>
            /// </summary>
            [NameInMap("EffectiveBandwidth")]
            [Validation(Required=false)]
            public string EffectiveBandwidth { get; set; }

            /// <summary>
            /// <para>The percentage of the inter-region bandwidth that can be consumed by the QoS queue.</para>
            /// <para>A value of <b>1</b> indicates that the QoS queue can consume at most 1% of the inter-region bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public int? RemainBandwidthPercent { get; set; }

            /// <summary>
            /// <para>The status of the QoS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Active</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-fv2qq9yqrsjowp****</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            /// <summary>
            /// <para>The description of the QoS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qosQueueDescription</para>
            /// </summary>
            [NameInMap("TrafficQosQueueDescription")]
            [Validation(Required=false)]
            public string TrafficQosQueueDescription { get; set; }

            /// <summary>
            /// <para>The ID of the QoS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-siakjb2nn9gz5z****</para>
            /// </summary>
            [NameInMap("TrafficQosQueueId")]
            [Validation(Required=false)]
            public string TrafficQosQueueId { get; set; }

            /// <summary>
            /// <para>The name of the QoS queue.</para>
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
            /// <para>The ID of the transit router.</para>
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
