// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryShortUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>Other values indicate that the request fails. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
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
        public QueryShortUrlResponseBodyData Data { get; set; }
        public class QueryShortUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the short URL was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-08 16:44:13</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The time when the short URL expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-22 11:21:11</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The PV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("PageViewCount")]
            [Validation(Required=false)]
            public string PageViewCount { get; set; }

            /// <summary>
            /// <para>The short URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.cn/6y8uy7</para>
            /// </summary>
            [NameInMap("ShortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

            /// <summary>
            /// <para>The service name of the short URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The Alibaba Cloud Short Link service.</para>
            /// </summary>
            [NameInMap("ShortUrlName")]
            [Validation(Required=false)]
            public string ShortUrlName { get; set; }

            /// <summary>
            /// <para>The status of the short URL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>expired</b></description></item>
            /// <item><description><b>effective</b></description></item>
            /// <item><description><b>audit</b></description></item>
            /// <item><description><b>reject</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>expired</para>
            /// </summary>
            [NameInMap("ShortUrlStatus")]
            [Validation(Required=false)]
            public string ShortUrlStatus { get; set; }

            /// <summary>
            /// <para>The source address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.****.com/product/sms">https://www.****.com/product/sms</a></para>
            /// </summary>
            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            /// <summary>
            /// <para>The UV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("UniqueVisitorCount")]
            [Validation(Required=false)]
            public string UniqueVisitorCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
