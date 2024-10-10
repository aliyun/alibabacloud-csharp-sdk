// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachDBInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which you want to attach the ApsaraDB RDS instance to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SecurityIp: the SecurityIp mode. Auto Scaling automatically adds the private IP addresses of the scaled out instances to the IP address whitelist of the ApsaraDB RDS instance. You can select this mode only when you attach an ApsaraDB RDS instance to a scaling group.</description></item>
        /// <item><description>SecurityGroup: the security group mode. Auto Scaling adds the security group of the scaling configuration to the security group whitelist for registration and association.</description></item>
        /// </list>
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
        /// <para>The ID of the ApsaraDB RDS instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<string> DBInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the private IP addresses of all instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. Valid values:</para>
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
        /// <item><description>ApsaraDB RDS</description></item>
        /// <item><description>ApsaraDB for Redis</description></item>
        /// <item><description>ApsaraDB for MongoDB</description></item>
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
