// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description>If <b>OK</b> is returned, the request is successful.</description></item>
        /// <item><description>For information about other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SendBatchCardSmsResponseBodyData Data { get; set; }
        public class SendBatchCardSmsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the card SMS sending task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BizCardId")]
            [Validation(Required=false)]
            public string BizCardId { get; set; }

            /// <summary>
            /// <para>The ID of the digital SMS sending task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3214</para>
            /// </summary>
            [NameInMap("BizDigitalId")]
            [Validation(Required=false)]
            public string BizDigitalId { get; set; }

            /// <summary>
            /// <para>The ID of the text SMS sending task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3256</para>
            /// </summary>
            [NameInMap("BizSmsId")]
            [Validation(Required=false)]
            public string BizSmsId { get; set; }

            /// <summary>
            /// <para>The review status of the card SMS template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Under review.</description></item>
            /// <item><description><b>1</b>: Approved.</description></item>
            /// <item><description><b>2</b>: Rejected.<remarks>
            /// <para>For SMS messages that are rejected, you can configure the fallback process by using the <b>FallbackType</b> parameter.</para>
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
            /// <para>The mobile phone numbers that receive the card SMS messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("MediaMobiles")]
            [Validation(Required=false)]
            public string MediaMobiles { get; set; }

            /// <summary>
            /// <para>The fallback phone numbers.</para>
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
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call is successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call fails.</para>
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
