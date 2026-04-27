// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentLoginRequest : TeaModel {
        /// <summary>
        /// <para>绑定电话</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("BindTel")]
        [Validation(Required=false)]
        public string BindTel { get; set; }

        /// <summary>
        /// <para>取值 1.普通电话,2.分机,3.webrtc </br>说明：绑定类型如果是分机则必须先让分机电话设备注册成功。如果绑定类型为webrtc，就算调用接口成功也是无法呼叫的。如果在企业设置页面开启了自适应绑定电话类型，则系统会根据绑定的号码来找到对应的绑定类型，使用系统找到的绑定类型，此处的设置优先级低。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BindType")]
        [Validation(Required=false)]
        public long? BindType { get; set; }

        /// <summary>
        /// <para>座席工号；取值3-10位正整数</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

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
        /// <para>登录状态，1：置闲，2：置忙，默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LoginStatus")]
        [Validation(Required=false)]
        public long? LoginStatus { get; set; }

        /// <summary>
        /// <para>置忙描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("PauseDescription")]
        [Validation(Required=false)]
        public string PauseDescription { get; set; }

    }

}
