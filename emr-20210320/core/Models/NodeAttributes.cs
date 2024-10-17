// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeAttributes : TeaModel {
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
