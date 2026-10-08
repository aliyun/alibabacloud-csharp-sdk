// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstancesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DescriptionForFuzzy")]
        [Validation(Required=false)]
        public string DescriptionForFuzzy { get; set; }

        /// <summary>
        /// <para>Queries instances by host IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("HostIp")]
        [Validation(Required=false)]
        public string HostIp { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is used to query a single instance.</para>
        /// <remarks>
        /// <para>If no instance ID is specified (neither <b>InstanceId</b> nor <b>InstanceIds</b> is passed), the operation returns detailed information about all RDS Custom instances in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rc-i2p26bde8bckf141****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// <para>This parameter is used to query multiple instances at a time. Separate multiple instance IDs with commas (,). A maximum of 100 IDs are supported. Input format: <c>[&quot;InstanceID1&quot;,&quot;InstanceID2&quot;]</c>.</para>
        /// <remarks>
        /// <para>If both <b>InstanceIds</b> and <b>InstanceId</b> are specified, the value of <b>InstanceIds</b> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rc-i2p26bde8bckf141****&quot;,&quot;rc-l1753m982otq2s2m****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number of the instance status list.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// <para>Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Queries instances by public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.89.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b>: Being created.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Starting</b>: Being started.</description></item>
        /// <item><description><b>Stopping</b>: Being stopped.</description></item>
        /// <item><description><b>Stopped</b>: Stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Queries instances by the specified tag. Input format: <c>{&quot;TagKey&quot;:&quot;TagValue&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testRC&quot;:&quot;test01&quot;}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
