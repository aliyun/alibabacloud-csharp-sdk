// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetExtenResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudGetExtenResponseBodyData Data { get; set; }
        public class CloudGetExtenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>语音编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>alaw,ulaw</para>
            /// </summary>
            [NameInMap("Allow")]
            [Validation(Required=false)]
            public string Allow { get; set; }

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
            /// <para>绑定的agent-gateway</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("BindGatewayId")]
            [Validation(Required=false)]
            public long? BindGatewayId { get; set; }

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
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-30 06:09:04</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>降噪开关 0:关闭 1:开启 默认关闭(该参数只有在类型为注册到webrtc才有效)</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Denoise")]
            [Validation(Required=false)]
            public long? Denoise { get; set; }

            /// <summary>
            /// <para>企业编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000002</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public string EnterpriseId { get; set; }

            /// <summary>
            /// <para>分机号，3-11位</para>
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
            /// <para>分机号id</para>
            /// 
            /// <b>Example:</b>
            /// <para>336450</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>是否允许摘机外呼，0：不允许，1：可以，默认允许</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDirect")]
            [Validation(Required=false)]
            public string IsDirect { get; set; }

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
            /// <para>外呼是否录音，0：不录音，1：录音，默认录音</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ObRecord")]
            [Validation(Required=false)]
            public long? ObRecord { get; set; }

            /// <summary>
            /// <para>密码</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aa248236</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
