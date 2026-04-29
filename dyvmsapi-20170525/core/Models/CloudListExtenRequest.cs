// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListExtenRequest : TeaModel {
        /// <summary>
        /// <para>区号</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// <para>呼叫权限，0：无限制，1：国内长途，2：国内本市，3：内部呼叫，默认无限制</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallPower")]
        [Validation(Required=false)]
        public string CallPower { get; set; }

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
        /// <para>分机号</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("Exten")]
        [Validation(Required=false)]
        public string Exten { get; set; }

        /// <summary>
        /// <para>呼入是否录音，0：不录用，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IbRecord")]
        [Validation(Required=false)]
        public long? IbRecord { get; set; }

        /// <summary>
        /// <para>是否被座席绑定，1 绑定 0未绑定</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsBind")]
        [Validation(Required=false)]
        public long? IsBind { get; set; }

        /// <summary>
        /// <para>是否允许外呼，0：不允许，1：可以，默认允许</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOb")]
        [Validation(Required=false)]
        public string IsOb { get; set; }

        /// <summary>
        /// <para>网络防抖</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JitterBuffer")]
        [Validation(Required=false)]
        public long? JitterBuffer { get; set; }

        /// <summary>
        /// <para>条数；正整数 大于0 小于等于500 默认为10条</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>外呼是否录音，0：不录音，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObRecord")]
        [Validation(Required=false)]
        public long? ObRecord { get; set; }

        /// <summary>
        /// <para>从第几条开始；正整数 默认为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>类型，1. 注册到IAD分机 2.注册到webrtc 3.注册到远程话机</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
