// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstancesRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Query by instance host IP address.</para>
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
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-i2p26bde8bckf141****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is used to query multiple instances simultaneously. Separate instance IDs with English commas (,), and up to 100 IDs are supported. The input format is: <c>[&quot;instance ID 1&quot;,&quot;instance ID 2&quot;]</c>.</para>
        /// <remarks>
        /// <para>When both <b>InstanceIds</b> and <b>instanceId</b> are provided, the value of <b>InstanceIds</b> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rc-i2p26bde8bckf141****&quot;,&quot;rc-l1753m982otq2s2m****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>Instance Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Page starts from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query by instance public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.89.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Instance status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b>: Creation in progress.  </description></item>
        /// <item><description><b>Running</b>: Running.  </description></item>
        /// <item><description><b>Starting</b>: Starting.  </description></item>
        /// <item><description><b>Stopping</b>: Pausing.  </description></item>
        /// <item><description><b>Stopped</b>: Paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Query by specified tag. The input format is: <c>{&quot;TagKey&quot;:&quot;TagValue&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testRC&quot;:&quot;test01&quot;}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
