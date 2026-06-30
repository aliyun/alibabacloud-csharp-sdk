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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no next page exists.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113BFD47-63DF-5D9D-972C-033FB9C360CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of QoS policies.</para>
        /// </summary>
        [NameInMap("TrafficQosPolicies")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies> TrafficQosPolicies { get; set; }
        public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies : TeaModel {
            /// <summary>
            /// <para>The bandwidth guarantee type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>byBandwidth</b>: The QoS queues are configured based on an absolute bandwidth value.</para>
            /// </description></item>
            /// <item><description><para><b>byBandwidthPercent</b>: The QoS queues are configured based on a bandwidth percentage.</para>
            /// </description></item>
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
            /// <item><description><para><b>Creating</b>: The policy is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: The policy is active.</para>
            /// </description></item>
            /// <item><description><para><b>Modifying</b>: The policy is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The policy is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("TrafficQosPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficQosPolicyStatus { get; set; }

            /// <summary>
            /// <para>The list of queues.</para>
            /// </summary>
            [NameInMap("TrafficQosQueues")]
            [Validation(Required=false)]
            public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues> TrafficQosQueues { get; set; }
            public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues : TeaModel {
                /// <summary>
                /// <para>The bandwidth value allocated to the queue of the inter-region connection. This parameter is returned when the bandwidth guarantee type is byBandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The Differentiated Services Code Point (DSCP) values of the traffic messages that are matched by the queue.</para>
                /// </summary>
                [NameInMap("Dscps")]
                [Validation(Required=false)]
                public List<int?> Dscps { get; set; }

                /// <summary>
                /// <para>The actual bandwidth of the queue.</para>
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
                /// <para>The ID of the queue.</para>
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
                /// <para>The percentage of the inter-region connection bandwidth that is used by the queue. This parameter is returned when the bandwidth guarantee type is byBandwidthPercent.</para>
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
            /// <para>The ID of the TransitRouter instance.</para>
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
