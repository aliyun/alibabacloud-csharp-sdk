// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query.</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned in the previous query, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113BFD47-63DF-5D9D-972C-033FB9C360CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of QoS policies.</para>
        /// </summary>
        [NameInMap("TrafficQosPolicies")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies> TrafficQosPolicies { get; set; }
        public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies : TeaModel {
            /// <summary>
            /// <para>带宽保障类型。</para>
            /// <list type="bullet">
            /// <item><description><b>byBandwidth</b>：按带宽绝对值模式配置QoS队列。</description></item>
            /// <item><description><b>byBandwidthPercent</b>：按带宽百分比模式配置QoS队列。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>byBandwidthPercent</para>
            /// </summary>
            [NameInMap("BandwidthGuaranteeMode")]
            [Validation(Required=false)]
            public string BandwidthGuaranteeMode { get; set; }

            /// <summary>
            /// <para>The description of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficQosPolicyDescription { get; set; }

            /// <summary>
            /// <para>The ID of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-rnghap5gc8155x****</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyName")]
            [Validation(Required=false)]
            public string TrafficQosPolicyName { get; set; }

            /// <summary>
            /// <para>The status of the QoS policy.</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The QoS policy is being created.</description></item>
            /// <item><description><b>Active</b>: The QoS policy is available.</description></item>
            /// <item><description><b>Modifying</b>: The policy is being modified.</description></item>
            /// <item><description><b>Deleting</b>: The QoS policy is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficQosPolicyStatus { get; set; }

            /// <summary>
            /// <para>A list of queues.</para>
            /// </summary>
            [NameInMap("TrafficQosQueues")]
            [Validation(Required=false)]
            public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues> TrafficQosQueues { get; set; }
            public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues : TeaModel {
                /// <summary>
                /// <para>带宽保障类型为按绝对值模式时，当前队列分配的跨地域带宽的值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The differentiated services code point (DSCP) value that is used to match packets.</para>
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
                /// <para>The description of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desctest</para>
                /// </summary>
                [NameInMap("QosQueueDescription")]
                [Validation(Required=false)]
                public string QosQueueDescription { get; set; }

                /// <summary>
                /// <para>The queue ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-queue-njcrmr9fiu1jii****</para>
                /// </summary>
                [NameInMap("QosQueueId")]
                [Validation(Required=false)]
                public string QosQueueId { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namtest</para>
                /// </summary>
                [NameInMap("QosQueueName")]
                [Validation(Required=false)]
                public string QosQueueName { get; set; }

                /// <summary>
                /// <para>The percentage of the inter-region bandwidth that can be used by the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RemainBandwidthPercent")]
                [Validation(Required=false)]
                public int? RemainBandwidthPercent { get; set; }

            }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-q7ct7c06jpw***</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2ze4ta4v32umj0rb***</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
