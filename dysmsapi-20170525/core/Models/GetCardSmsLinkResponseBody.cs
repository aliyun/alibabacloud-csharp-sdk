// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardSmsLinkResponseBodyData Data { get; set; }
        public class GetCardSmsLinkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The mobile phone numbers that support card messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;1390000****\&quot;,\&quot;1370000****\&quot;]</para>
            /// </summary>
            [NameInMap("CardPhoneNumbers")]
            [Validation(Required=false)]
            public string CardPhoneNumbers { get; set; }

            /// <summary>
            /// <para>The signatures must correspond to the mobile numbers and short URLs in sequence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;aliyun&quot;,&quot;aliyun2&quot;]</para>
            /// </summary>
            [NameInMap("CardSignNames")]
            [Validation(Required=false)]
            public string CardSignNames { get; set; }

            /// <summary>
            /// <para>The short URLs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;mw2m.cn/LAaGGa\&quot;,\&quot;mw2m.cn/LAAaes\&quot;]</para>
            /// </summary>
            [NameInMap("CardSmsLinks")]
            [Validation(Required=false)]
            public string CardSmsLinks { get; set; }

            /// <summary>
            /// <para>The review status of the card message template.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: pending approval</description></item>
            /// <item><description><b>1</b>: approved</description></item>
            /// <item><description><b>2</b>: rejected</description></item>
            /// </list>
            /// <remarks>
            /// <para>Unapproved card messages are rolled back.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }

            /// <summary>
            /// <para>The mobile phone numbers that do not support card messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("NotMediaMobiles")]
            [Validation(Required=false)]
            public string NotMediaMobiles { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC89A90C-978F-46AC-B80D-54738371E7CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
