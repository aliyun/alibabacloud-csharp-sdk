// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachDBInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which you want to attach the database to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SecurityIp: adds the private IP addresses of scaled out ECS instances to the IP address whitelist of the database. Take note that you can choose this mode only when the database that you want to attach is an ApsaraDB RDS instance.</description></item>
        /// <item><description>SecurityGroup: adds the security group of the scaling configuration based on which ECS instances are created in the scaling group to the security group whitelist of the database for registration.</description></item>
        /// </list>
        /// <para>Default value: SecurityIp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecurityIp</para>
        /// </summary>
        [NameInMap("AttachMode")]
        [Validation(Required=false)]
        public string AttachMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.</para>
        /// <para>The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure the idempotence of a request</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IDs of the ApsaraDB RDS instances that you want to attach to the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<string> DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the private IP addresses of all ECS instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance that you want to attach to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1avr6ensitts3w****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The type of the database that you want to attach to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RDS</description></item>
        /// <item><description>Redis</description></item>
        /// <item><description>MongoDB</description></item>
        /// </list>
        /// <para>Default value: RDS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
