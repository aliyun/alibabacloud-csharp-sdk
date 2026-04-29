// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAssignAgentGroupRequest : TeaModel {
        /// <summary>
        /// <para>说明：多个座席编号之间以英文逗号( , )分隔，一次最多支持1000个cno；同一座席只能存在于一个外呼组，重复分配会自动移动到新的外呼组中</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000,1111</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>外呼组编号；说明：添加此gno对应的外呼组与cnos对应的座席的绑定从属关系; 同一外呼组最多可包含1000个座席</para>
        /// 
        /// <b>Example:</b>
        /// <para>WH123</para>
        /// </summary>
        [NameInMap("Gno")]
        [Validation(Required=false)]
        public string Gno { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
