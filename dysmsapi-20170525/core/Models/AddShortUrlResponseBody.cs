// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddShortUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of <c>OK</c> indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error Code List</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the short URL.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddShortUrlResponseBodyData Data { get; set; }
        public class AddShortUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of the short URL.</para>
            /// <remarks>
            /// <para>The value of <b>ExpireDate</b> is always on the hour.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-19 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The generated short URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.cn/6y8uy7</para>
            /// </summary>
            [NameInMap("ShortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

            /// <summary>
            /// <para>The source URL that was shortened.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.****.com/product/sms">https://www.****.com/product/sms</a></para>
            /// </summary>
            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

        }

        /// <summary>
        /// <para>The message that describes the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819BE656-D2E0-4858-8B21-B2E477085AAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
