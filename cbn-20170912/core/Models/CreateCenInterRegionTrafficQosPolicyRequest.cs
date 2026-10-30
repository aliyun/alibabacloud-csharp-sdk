// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth guarantee mode. You can specify an absolute bandwidth value or a bandwidth percentage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>byBandwidth</b>: configures the QoS queue based on an absolute bandwidth value.</para>
        /// </description></item>
        /// <item><description><para><b>byBandwidthPercent</b> (default): configures the QoS queue based on a bandwidth percentage.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the inter-region traffic QoS policy. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, the inter-region traffic QoS policy is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ConsoleDryRun")]
        [Validation(Required=false)]
        public bool? ConsoleDryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the traffic QoS policy. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, the traffic QoS policy is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The description of the traffic QoS policy.</para>
        /// <para>The description must be 1 to 256 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficQosPolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic QoS policy.</para>
        /// <para>The name must be 1 to 128 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyName")]
        [Validation(Required=false)]
        public string TrafficQosPolicyName { get; set; }

        /// <summary>
        /// <para>The information about the queues in the traffic QoS policy.</para>
        /// <para>You can create up to three queues. To create more queues, call the CreateCenInterRegionTrafficQosQueue operation.</para>
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues> TrafficQosQueues { get; set; }
        public class CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues : TeaModel {
            /// <summary>
            /// <para>The absolute value of the inter-region bandwidth that the queue can use. Unit: Mbit/s.</para>
            /// <para>You can create up to 10 queues in a traffic QoS policy and specify the inter-region bandwidth that each queue can use.</para>
            /// <para>For example, if you enter 1, packets that match the queue can use up to 1 Mbit/s of the inter-region bandwidth.</para>
            /// <remarks>
            /// <para>The sum of the absolute values of the inter-region bandwidth allocated to all queues in a traffic QoS policy cannot exceed the total inter-region bandwidth.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The DSCP values that match the queue.</para>
            /// <para>You can create up to three queues in a traffic QoS policy. Each queue can match up to 60 DSCP values. Separate multiple DSCP values with commas (,).</para>
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// <para>The description of the queue.</para>
            /// <para>You can create up to 10 queues in a traffic QoS policy and add a description to each queue.</para>
            /// <para>The description must be 1 to 256 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("QosQueueDescription")]
            [Validation(Required=false)]
            public string QosQueueDescription { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
            /// <para>You can create up to three queues in a traffic QoS policy and specify a name for each queue.</para>
            /// <para>The name must be 1 to 128 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("QosQueueName")]
            [Validation(Required=false)]
            public string QosQueueName { get; set; }

            /// <summary>
            /// <para>The percentage of the inter-region bandwidth that the queue can use.</para>
            /// <para>You can create up to 10 queues in a traffic QoS policy and specify the percentage of the inter-region bandwidth that each queue can use.</para>
            /// <para>For example, if you enter <b>1</b>, packets that match the queue can use up to 1% of the inter-region bandwidth.</para>
            /// <remarks>
            /// <para>The sum of the inter-region bandwidth percentages of all queues in a traffic QoS policy cannot exceed 100%.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public string RemainBandwidthPercent { get; set; }

        }

        /// <summary>
        /// <para>The ID of the inter-region connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-r6g0m3epjehw57****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The transit router instance ID, which is used for forward and routing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-8vbuqeo5h5pu3m01d****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
