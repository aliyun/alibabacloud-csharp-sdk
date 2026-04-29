// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateExtenRequest : TeaModel {
        /// <summary>
        /// <para>允许的语音编码,支持格式: 1. g729 2. g729,alaw,ulaw 3. alaw,ulaw,g729 4. alaw,ulaw 5. myopus,alaw,ulaw5. myopus,alaw,ulaw6. myopus,g729,alaw,ulaw 7. myopus,g729 公网+远程话机支持配置1/2/3;专线+远程话机支持配置1/2;公网+软电话支持配置4;专线+软电话支持配置5;</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Allow")]
        [Validation(Required=false)]
        public string Allow { get; set; }

        /// <summary>
        /// <para>区号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// <para>呼叫权限；0：无限制，1：国内长途，2：国内本市，3：内部呼叫，默认无限制</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallPower")]
        [Validation(Required=false)]
        public string CallPower { get; set; }

        /// <summary>
        /// <para>降噪开关；0:关闭 1:开启 (该参数只有在类型为注册到webrtc才有效)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Denoise")]
        [Validation(Required=false)]
        public string Denoise { get; set; }

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
        /// <para>分机号,3-11位</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("Exten")]
        [Validation(Required=false)]
        public string Exten { get; set; }

        /// <summary>
        /// <para>iad网关；该参数只有在类型为，注册到IAD分机，才有效</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("IadName")]
        [Validation(Required=false)]
        public string IadName { get; set; }

        /// <summary>
        /// <para>呼入是否录音；0：不录用，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IbRecord")]
        [Validation(Required=false)]
        public long? IbRecord { get; set; }

        /// <summary>
        /// <para>是否允许摘机外呼，0：不允许，1：可以，默认允许</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDirect")]
        [Validation(Required=false)]
        public long? IsDirect { get; set; }

        /// <summary>
        /// <para>是否允许外呼；0：不允许，1：可以，默认允许</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOb")]
        [Validation(Required=false)]
        public string IsOb { get; set; }

        /// <summary>
        /// <para>网络防抖；0：关闭，1：开启，默认关闭</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("JitterBuffer")]
        [Validation(Required=false)]
        public long? JitterBuffer { get; set; }

        /// <summary>
        /// <para>外呼是否录音；0：不录音，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObRecord")]
        [Validation(Required=false)]
        public long? ObRecord { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>密码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aa248236</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>属性</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>类型；1. 注册到IAD分机 2.注册到webrtc 3.注册到远程话机</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
