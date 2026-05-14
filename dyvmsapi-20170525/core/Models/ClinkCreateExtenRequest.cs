// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCreateExtenRequest : TeaModel {
        /// <summary>
        /// <para>语音编码。 IP话机支持的语音编码：1、2、3、4、5 软电话支持的语音编码：5、6 1：g729(已弃用) 2：g729,alaw,ulaw 3：alaw,ulaw,g729 4：myopus,alaw,ulaw,g729 5：alaw,ulaw 6：myopus,alaw,ulaw</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Allow")]
        [Validation(Required=false)]
        public long? Allow { get; set; }

        /// <summary>
        /// <para>话机区号。以 0 开头 3-4 位数字</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>话机号码。3-6 位数字，要求唯一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12235</para>
        /// </summary>
        [NameInMap("ExtenNumber")]
        [Validation(Required=false)]
        public string ExtenNumber { get; set; }

        /// <summary>
        /// <para>是否允许主叫外呼，1：允许；0：不允许。话机类型为IP话机时，可以开启主叫外呼功能，直接通过IP话机进行外呼。若要使用主叫外呼功能，需要开启企业级开关。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDirect")]
        [Validation(Required=false)]
        public long? IsDirect { get; set; }

        /// <summary>
        /// <para>网络防抖，0：关闭；1：开启，默认关闭，当开启时，语音编码类型默认为5</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("JittBuffer")]
        [Validation(Required=false)]
        public long? JittBuffer { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>话机密码，密码规则参见企业配置</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>话机类型。1: IP话机， 2: 软电话</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
