// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeAttributes : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable encryption for the data disk. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/ecs/user-guide/encrypt-a-data-disk">Encrypt a data disk</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/ecs/user-guide/encryption-overview">Encrypt a data disk</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables encryption.</para>
        /// </description></item>
        /// <item><description><para>false (default): Disables encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DataDiskEncrypted")]
        [Validation(Required=false)]
        public bool? DataDiskEncrypted { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key for the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("DataDiskKMSKeyId")]
        [Validation(Required=false)]
        public string DataDiskKMSKeyId { get; set; }

        /// <summary>
        /// <para>The SSH key pair for logging on to the ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr_login</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The password of the root user for the master node. This parameter is left empty in the response of an API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAQ#86****</para>
        /// </summary>
        [NameInMap("MasterRootPassword")]
        [Validation(Required=false)]
        public string MasterRootPassword { get; set; }

        /// <summary>
        /// <para>The RAM role that is attached to the ECS instances to access other cloud resources.
        /// Default value: AliyunECSInstanceForEMRRole.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSInstanceForEMRRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the security group. EMR supports only basic security groups and does not support enterprise security groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-hp3abbae8lb6lmb1****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disk encryption for the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables encryption.</para>
        /// </description></item>
        /// <item><description><para>false (default): Disables encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SystemDiskEncrypted")]
        [Validation(Required=false)]
        public bool? SystemDiskEncrypted { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("SystemDiskKMSKeyId")]
        [Validation(Required=false)]
        public string SystemDiskKMSKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1tgey2p0ytxmdo5****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
