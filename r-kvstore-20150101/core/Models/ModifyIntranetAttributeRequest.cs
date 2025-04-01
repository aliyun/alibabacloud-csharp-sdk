// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyIntranetAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The amount of bandwidth that you want to add. Unit: Mbit/s. The value must be an integer greater than or equal to 0. In most cases, the maximum bandwidth that can be added can be two times the default maximum bandwidth of the current instance type. For more information about the bandwidth specifications supported by different instance types, see <a href="https://help.aliyun.com/document_detail/26350.html">Overview</a>. The bandwidth is also subject to the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The bandwidth of an individual instance cannot exceed 75% of the bandwidth of the host. For more information about the host specifications and bandwidth, see <a href="https://help.aliyun.com/document_detail/206343.html">Instance types of hosts</a>.</description></item>
        /// <item><description>The total bandwidth of all of the instances on the host cannot exceed 150% of the bandwidth of the host. You can configure resource overcommitment to handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/183798.html">Configure resource overcommitment to reduce costs</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter for a standard instance, the bandwidth of the instance is set to two times that of the current bandwidth.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BandWidth")]
        [Validation(Required=false)]
        public long? BandWidth { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data node. You can call the <a href="https://help.aliyun.com/document_detail/473783.html">DescribeClusterMemberInfo</a> operation to query the node ID. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter is required if the instance is a <a href="https://help.aliyun.com/document_detail/52228.html">cluster</a> instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
