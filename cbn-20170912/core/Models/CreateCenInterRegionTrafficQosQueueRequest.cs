// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosQueueRequest : TeaModel {
        /// <summary>
        /// <para>The maximum cross-region bandwidth that the queue can use when bandwidth is allocated in absolute value mode. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description><para>The bandwidth value is calculated as an absolute value. For example, if you enter 20, the queue can use up to 20 Mbit/s of the cross-region bandwidth.</para>
        /// </description></item>
        /// <item><description><para>The sum of the bandwidth of all queues under a cross-region connection instance cannot exceed the cross-region bandwidth.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request and does not create the queue. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the check, the system returns an error. If the request passes the check, the system returns the <c>DryRunOperation</c> error code.</description></item>
        /// <item><description><b>false</b> (default): sends a regular request and creates the queue after the request passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The Differentiated Services Code Point (DSCP) values to be matched by the queue.</para>
        /// <para>You can enter up to 20 DSCP values at a time. Separate multiple DSCP values with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Dscps")]
        [Validation(Required=false)]
        public List<int?> Dscps { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the queue.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("QosQueueDescription")]
        [Validation(Required=false)]
        public string QosQueueDescription { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("QosQueueName")]
        [Validation(Required=false)]
        public string QosQueueName { get; set; }

        /// <summary>
        /// <para>The maximum cross-region bandwidth that the queue can use when bandwidth is allocated in percentage mode.</para>
        /// <list type="bullet">
        /// <item><description><para>The bandwidth value is calculated as a percentage. For example, if you enter 20, the queue can use up to 20% of the cross-region bandwidth.</para>
        /// </description></item>
        /// <item><description><para>The sum of the bandwidth percentages of all queues under a cross-region connection instance cannot exceed 100%.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RemainBandwidthPercent")]
        [Validation(Required=false)]
        public string RemainBandwidthPercent { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the traffic scheduling policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-qdvybn468kaoxx****</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

    }

}
