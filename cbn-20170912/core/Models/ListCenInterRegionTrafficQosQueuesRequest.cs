// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by the actual bandwidth. Only positive integers are supported. Unit: Mbit/s.</para>
        /// </summary>
        [NameInMap("EffectiveBandwidthFilter")]
        [Validation(Required=false)]
        public ListCenInterRegionTrafficQosQueuesRequestEffectiveBandwidthFilter EffectiveBandwidthFilter { get; set; }
        public class ListCenInterRegionTrafficQosQueuesRequestEffectiveBandwidthFilter : TeaModel {
            /// <summary>
            /// <para>The actual bandwidth is greater than or equal to the specified value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Gte")]
            [Validation(Required=false)]
            public long? Gte { get; set; }

            /// <summary>
            /// <para>The actual bandwidth is less than or equal to the specified value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Lte")]
            [Validation(Required=false)]
            public long? Lte { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It is used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no more results are returned.</para>
        /// </description></item>
        /// <item><description><para>If NextToken is not empty, the value of <b>NextToken</b> is used for the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2ca1ed1573cb****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The ID of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-rnghap5gc8155x****</para>
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

        /// <summary>
        /// <para>The description of the queue in the QoS policy.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qosQueueDescription</para>
        /// </summary>
        [NameInMap("TrafficQosQueueDescription")]
        [Validation(Required=false)]
        public string TrafficQosQueueDescription { get; set; }

        /// <summary>
        /// <para>The ID of the queue in the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-siakjb2nn9gz5z****</para>
        /// </summary>
        [NameInMap("TrafficQosQueueId")]
        [Validation(Required=false)]
        public string TrafficQosQueueId { get; set; }

        /// <summary>
        /// <para>The name of the queue in the QoS policy.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
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
        /// <para>tr-attach-a6p8voaodog5c0****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1rmwxnk221e3fas****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
