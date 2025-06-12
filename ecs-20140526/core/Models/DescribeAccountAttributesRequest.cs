// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The type of resource quota N. Valid values of N: 1 to 8. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance-network-type: the available network types.</para>
        /// </description></item>
        /// <item><description><para>max-security-groups: the maximum number of security groups.</para>
        /// </description></item>
        /// <item><description><para>max-elastic-network-interfaces: the maximum number of ENIs.</para>
        /// </description></item>
        /// <item><description><para>max-postpaid-instance-vcpu-count: the maximum number of vCPUs for pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>max-spot-instance-vcpu-count: the maximum number of vCPUs for spot instances.</para>
        /// </description></item>
        /// <item><description><para>used-postpaid-instance-vcpu-count: the number of vCPUs that have been allocated to pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>used-spot-instance-vcpu-count: the number of vCPUs that have been allocated to spot instances.</para>
        /// </description></item>
        /// <item><description><para>max-postpaid-yundisk-capacity: the maximum capacity of pay-as-you-go data disks. (The value is deprecated.)</para>
        /// </description></item>
        /// <item><description><para>used-postpaid-yundisk-capacity: the capacity of pay-as-you-go data disks that have been created. (The value is deprecated.)</para>
        /// </description></item>
        /// <item><description><para>max-dedicated-hosts: the maximum number of dedicated hosts.</para>
        /// </description></item>
        /// <item><description><para>supported-postpaid-instance-types: the instance types of pay-as-you-go I/O optimized instances.</para>
        /// </description></item>
        /// <item><description><para>max-axt-command-count: the maximum number of Cloud Assistant commands.</para>
        /// </description></item>
        /// <item><description><para>max-axt-invocation-daily: the maximum number of Cloud Assistant command executions per day.</para>
        /// </description></item>
        /// <item><description><para>real-name-authentication: whether the account has completed the real-name verification.</para>
        /// <para>**</para>
        /// <para><b>Note</b> To create an ECS instance in a region in the Chinese mainland, you must complete the real-name verification.</para>
        /// </description></item>
        /// <item><description><para>max-cloud-assistant-activation-count: the maximum number of activation codes that can be created to use to register managed instances.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>max-security-groups</para>
        /// </summary>
        [NameInMap("AttributeName")]
        [Validation(Required=false)]
        public List<string> AttributeName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which the resource resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
