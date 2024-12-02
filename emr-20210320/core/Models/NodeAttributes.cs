// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeAttributes : TeaModel {
        /// <summary>
        /// <para>是否启用云盘加密。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：启用加密。</description></item>
        /// <item><description>false：不加密。</description></item>
        /// </list>
        /// <para>默认值：false，不加密</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DataDiskEncrypted")]
        [Validation(Required=false)]
        public bool? DataDiskEncrypted { get; set; }

        /// <summary>
        /// <para>KMS加密秘钥ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("DataDiskKMSKeyId")]
        [Validation(Required=false)]
        public string DataDiskKMSKeyId { get; set; }

        /// <summary>
        /// <para>ECS ssh登录秘钥。</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr_login</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>MASTER节点root密码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Adxefswfd****</para>
        /// </summary>
        [NameInMap("MasterRootPassword")]
        [Validation(Required=false)]
        public string MasterRootPassword { get; set; }

        /// <summary>
        /// <para>ECS访问资源绑定的角色。</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSInstanceForEMRRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>安全组ID。EMR只支持普通安全组，不支持企业安全组。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-hp3abbae8lb6lmb1****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>是否启用云盘加密。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：启用加密。</description></item>
        /// <item><description>false：不加密。</description></item>
        /// </list>
        /// <para>默认值：false，不加密</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SystemDiskEncrypted")]
        [Validation(Required=false)]
        public bool? SystemDiskEncrypted { get; set; }

        /// <summary>
        /// <para>KMS加密秘钥ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("SystemDiskKMSKeyId")]
        [Validation(Required=false)]
        public string SystemDiskKMSKeyId { get; set; }

        /// <summary>
        /// <para>专有网络ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1tgey2p0ytxmdo5****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>可用区ID。</para>
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
