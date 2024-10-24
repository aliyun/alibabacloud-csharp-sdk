// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</description></item>
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
        public SendBatchCardSmsResponseBodyData Data { get; set; }
        public class SendBatchCardSmsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the card message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BizCardId")]
            [Validation(Required=false)]
            public string BizCardId { get; set; }

            /// <summary>
            /// <para>The ID of the digital message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3214</para>
            /// </summary>
            [NameInMap("BizDigitalId")]
            [Validation(Required=false)]
            public string BizDigitalId { get; set; }

            /// <summary>
            /// <para>The ID of the text message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3256</para>
            /// </summary>
            [NameInMap("BizSmsId")]
            [Validation(Required=false)]
            public string BizSmsId { get; set; }

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
            /// <para>The mobile phone number from which the card message is sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("MediaMobiles")]
            [Validation(Required=false)]
            public string MediaMobiles { get; set; }

            /// <summary>
            /// <para>The mobile phone number whose card message is rolled back.</para>
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
