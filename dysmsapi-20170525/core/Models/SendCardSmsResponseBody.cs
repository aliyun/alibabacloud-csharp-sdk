// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendCardSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description>返回OK代表请求成功。</description></item>
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
        public SendCardSmsResponseBodyData Data { get; set; }
        public class SendCardSmsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>卡片短信发送ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BizCardId")]
            [Validation(Required=false)]
            public string BizCardId { get; set; }

            /// <summary>
            /// <para>数字短信发送ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("BizDigitalId")]
            [Validation(Required=false)]
            public string BizDigitalId { get; set; }

            /// <summary>
            /// <para>文本短信发送ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>524</para>
            /// </summary>
            [NameInMap("BizSmsId")]
            [Validation(Required=false)]
            public string BizSmsId { get; set; }

            /// <summary>
            /// <para>卡片短信模板审核状态。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：审核中。</description></item>
            /// <item><description><b>1</b>：审核通过。</description></item>
            /// <item><description><b>2</b>：审核不通过。<remarks>
            /// <para> 审核不通过的短信可通过<b>FallbackType</b>字段设置回落流程。</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }

            /// <summary>
            /// <para>接收卡片短信的手机号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("MediaMobiles")]
            [Validation(Required=false)]
            public string MediaMobiles { get; set; }

            /// <summary>
            /// <para>回落的手机号。</para>
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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D28D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>：调用成功。</para>
        /// </description></item>
        /// <item><description><para><b>false</b>：调用失败。</para>
        /// </description></item>
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
