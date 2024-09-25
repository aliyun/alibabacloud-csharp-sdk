// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressConnectTrafficQosQueueRequest : TeaModel {
        /// <summary>
        /// <para>The percentage of bandwidth allocated to the QoS queue.</para>
        /// <list type="bullet">
        /// <item><description>If QueueType is set to <b>Medium</b>, this parameter is required. Valid values: 1 to 100.</description></item>
        /// <item><description>If QueueType is set to <b>Default</b>, a value of - is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BandwidthPercent")]
        [Validation(Required=false)]
        public string BandwidthPercent { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among all requests. ClientToken can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> for each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv4700</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The description of the QoS queue.</para>
        /// <para>It must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-test</para>
        /// </summary>
        [NameInMap("QueueDescription")]
        [Validation(Required=false)]
        public string QueueDescription { get; set; }

        /// <summary>
        /// <para>The name of the QoS queue.</para>
        /// <para>It must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-test</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The priority of the QoS queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>High</b></description></item>
        /// <item><description><b>Medium</b></description></item>
        /// <item><description><b>Default</b>: default queue.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You cannot create a QoS queue of the default priority.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("QueueType")]
        [Validation(Required=false)]
        public string QueueType { get; set; }

        /// <summary>
        /// <para>The region ID of the QoS policy.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
