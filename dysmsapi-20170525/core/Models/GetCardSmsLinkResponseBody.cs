// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。取值：</para>
        /// <list type="bullet">
        /// <item><description>OK：代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见<a href="https://help.aliyun.com/document_detail/101346.html">错误码列表</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardSmsLinkResponseBodyData Data { get; set; }
        public class GetCardSmsLinkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>支持卡片短信的手机号码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;1390000****\&quot;,\&quot;1370000****\&quot;]</para>
            /// </summary>
            [NameInMap("CardPhoneNumbers")]
            [Validation(Required=false)]
            public string CardPhoneNumbers { get; set; }

            /// <summary>
            /// <para>用于申请卡片短信短链的短信签名，在发送时签名、接收号码、卡片短信短链要一一对应。</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;阿里云&quot;,&quot;阿里云2&quot;]</para>
            /// </summary>
            [NameInMap("CardSignNames")]
            [Validation(Required=false)]
            public string CardSignNames { get; set; }

            /// <summary>
            /// <para>卡片短信短链。</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;mw2m.cn/LAaGGa\&quot;,\&quot;mw2m.cn/LAAaes\&quot;]</para>
            /// </summary>
            [NameInMap("CardSmsLinks")]
            [Validation(Required=false)]
            public string CardSmsLinks { get; set; }

            /// <summary>
            /// <para>卡片短信模板审核状态。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：审核中。</description></item>
            /// <item><description><b>1</b>：审核通过。</description></item>
            /// <item><description><b>2</b>：审核不通过。</description></item>
            /// </list>
            /// <remarks>
            /// <para>未审核通过的短信走回落流程。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }

            /// <summary>
            /// <para>不支持卡片短信的手机号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("NotMediaMobiles")]
            [Validation(Required=false)]
            public string NotMediaMobiles { get; set; }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC89A90C-978F-46AC-B80D-54738371E7CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>接口调用是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>：调用成功。</description></item>
        /// <item><description><b>false</b>：调用失败。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
