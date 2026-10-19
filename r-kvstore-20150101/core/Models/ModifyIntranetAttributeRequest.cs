// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyIntranetAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth to add, in MB/s. The value must be an integer greater than or equal to 0. Typically, the maximum value is twice the default maximum bandwidth of the current instance type. For bandwidth information about each instance type, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance type navigation</a>. However, the following limits also apply:</para>
        /// <list type="bullet">
        /// <item><description>The bandwidth of a single instance cannot exceed 75% of the bandwidth of the host on which the instance resides. For information about host specifications and bandwidth, see <a href="https://help.aliyun.com/document_detail/206343.html">Host specification details</a>.</description></item>
        /// <item><description>The total bandwidth of all instances on a host cannot exceed 150% of the bandwidth of the host. You can configure overcommitment to meet bandwidth requirements for staggered-peak deployment. For more information, see <a href="https://help.aliyun.com/document_detail/183798.html">Configure cluster overcommitment to reduce costs</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For instances that use the standard architecture, if you do not specify this parameter, the bandwidth of the instance is doubled based on the current bandwidth.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BandWidth")]
        [Validation(Required=false)]
        public long? BandWidth { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data node. You can call <a href="https://help.aliyun.com/document_detail/473783.html">DescribeClusterMemberInfo</a> to query the ID. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the instance uses the <a href="https://help.aliyun.com/document_detail/52228.html">Cluster Edition</a>.</para>
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
