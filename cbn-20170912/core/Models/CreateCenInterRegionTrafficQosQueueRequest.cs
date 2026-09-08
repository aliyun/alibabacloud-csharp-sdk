// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosQueueRequest : TeaModel {
        /// <summary>
        /// <para>The maximum inter-region bandwidth that the queue can use when bandwidth is allocated by absolute value. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description><para>The bandwidth value is calculated as an absolute value. For example, if you enter 20, the queue can use up to 20 Mbit/s of inter-region bandwidth.</para>
        /// </description></item>
        /// <item><description><para>The sum of the bandwidth values of all queues under an inter-region connection cannot exceed the inter-region bandwidth value.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, the queue is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The DSCP values to be matched by the queue.</para>
        /// <para>You can specify up to 20 DSCP values at a time. Separate multiple DSCP values with commas (,).</para>
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
        /// <para>The description can be empty or 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("QosQueueDescription")]
        [Validation(Required=false)]
        public string QosQueueDescription { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// <para>The name can be empty or 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("QosQueueName")]
        [Validation(Required=false)]
        public string QosQueueName { get; set; }

        /// <summary>
        /// <para>The maximum inter-region bandwidth that the queue can use when bandwidth is allocated by percentage.</para>
        /// <list type="bullet">
        /// <item><description><para>The bandwidth value is calculated as a percentage. For example, if you enter 20, the queue can use up to 20% of the inter-region bandwidth.</para>
        /// </description></item>
        /// <item><description><para>The sum of the bandwidth percentages of all queues under an inter-region connection cannot exceed 100%.</para>
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
