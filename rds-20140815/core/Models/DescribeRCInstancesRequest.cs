// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The RDS Custom container cluster ID used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The description used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The keyword used to perform a fuzzy match on the instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("DescriptionForFuzzy")]
        [Validation(Required=false)]
        public string DescriptionForFuzzy { get; set; }

        /// <summary>
        /// <para>The host IP address used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("HostIp")]
        [Validation(Required=false)]
        public string HostIp { get; set; }

        /// <summary>
        /// <para>The image ID used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-dsvjzw2ii8n4******</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is used to query a single instance.</para>
        /// <remarks>
        /// <para>If no instance ID is specified (neither <b>InstanceId</b> nor <b>InstanceIds</b> is specified), the details of all RDS Custom instances in the specified region are returned.</para>
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
        /// <para>This parameter is used to query multiple instances at a time. Separate multiple instance IDs with commas (,). You can specify up to 100 instance IDs. Input format: <c>[&quot;InstanceId1&quot;,&quot;InstanceId2&quot;]</c>.</para>
        /// <remarks>
        /// <para>If both <b>InstanceIds</b> and <b>InstanceId</b> are specified, the value of <b>InstanceIds</b> prevails.</para>
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
        /// <para>Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
        /// <para>Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The public IP address used to filter instances.</para>
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
        /// <item><description><b>Pending</b>: The instance is being created.</description></item>
        /// <item><description><b>Running</b>: The instance is running.</description></item>
        /// <item><description><b>Starting</b>: The instance is starting.</description></item>
        /// <item><description><b>Stopping</b>: The instance is being stopped.</description></item>
        /// <item><description><b>Stopped</b>: The instance is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags used to filter instances. Input format: <c>{&quot;TagKey&quot;:&quot;TagValue&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testRC&quot;:&quot;test01&quot;}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
