// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosPolicyRequest : TeaModel {
        [NameInMap("BandwidthGuaranteeMode")]
        [Validation(Required=false)]
        public string BandwidthGuaranteeMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether only to precheck the API request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request but does not create the QoS policy. The system checks the required parameters, the request format, and the service limits. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the API request. If the request passes the precheck, the QoS policy is created. This is the default value.</description></item>
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
        /// <para>The description of the QoS policy.</para>
        /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficQosPolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the QoS policy.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyName")]
        [Validation(Required=false)]
        public string TrafficQosPolicyName { get; set; }

        /// <summary>
        /// <para>The information about the QoS queue.</para>
        /// <para>You can add at most three QoS queues in a QoS policy by calling this operation. To add more QoS queues, call the CreateCenInterRegionTrafficQosQueue operation.</para>
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues> TrafficQosQueues { get; set; }
        public class CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value that matches the current queue.</para>
            /// <para>Each QoS policy supports at most three queues. You can specify at most 60 DSCP values for each queue. Separate multiple DCSP values with commas (,).</para>
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// <para>The description of the current queue.</para>
            /// <para>Each QoS policy supports at most three queues. You can specify a description for each queue.</para>
            /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("QosQueueDescription")]
            [Validation(Required=false)]
            public string QosQueueDescription { get; set; }

            /// <summary>
            /// <para>The name of the current queue.</para>
            /// <para>Each QoS policy supports at most three queues. You can specify a name for each queue.</para>
            /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("QosQueueName")]
            [Validation(Required=false)]
            public string QosQueueName { get; set; }

            /// <summary>
            /// <para>The percentage of the inter-region bandwidth that can be used by the queue.</para>
            /// <para>Each QoS policy supports at most three queues. You can specify a valid percentage for each queue.</para>
            /// <para>For example, a value of <b>1</b> specifies that the queue can consume 1% of the inter-region bandwidth.</para>
            /// <remarks>
            /// <para> The sum of the percentage values of all the queues in a QoS policy cannot exceed 100%.</para>
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
        /// <para>The ID of the transit router.</para>
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
