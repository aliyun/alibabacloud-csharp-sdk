// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachDBInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The association mode between the scaling group and the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SecurityIp: The SecurityIp mode. In this mode, the IP addresses of scaled-out instances are automatically added to the IP address whitelist of the database. Currently, only ApsaraDB RDS databases support this mode.</description></item>
        /// <item><description>SecurityGroup: The security group mode. In this mode, the security group of the scaling configuration is added to the security group whitelist of the database for association and registration.</description></item>
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
        /// <para>Ensures the idempotence of the request. You can generate a parameter value from your client to ensure that the parameter value is unique across different requests.</para>
        /// <para>The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IDs of the RDS instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<string> DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the private IP addresses of all instances in the current scaling group to the IP address whitelist of the RDS instances when the RDS instances are attached to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Adds the private IP addresses.</para>
        /// </description></item>
        /// <item><description><para>false: Does not add the private IP addresses.</para>
        /// </description></item>
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
        /// <para>The database type. Valid values:</para>
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
