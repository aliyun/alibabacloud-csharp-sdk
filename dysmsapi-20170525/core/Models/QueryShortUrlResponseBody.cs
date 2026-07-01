// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryShortUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A successful request returns <c>OK</c>.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
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
        /// <para>The details of the short link.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryShortUrlResponseBodyData Data { get; set; }
        public class QueryShortUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation date and time of the short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-08 16:44:13</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The expiration date and time of the short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-22 11:21:11</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The page view (PV) count for the short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("PageViewCount")]
            [Validation(Required=false)]
            public string PageViewCount { get; set; }

            /// <summary>
            /// <para>The generated short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.cn/6y8uy7</para>
            /// </summary>
            [NameInMap("ShortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

            /// <summary>
            /// <para>The name of the service that generated the short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里短链测试</para>
            /// </summary>
            [NameInMap("ShortUrlName")]
            [Validation(Required=false)]
            public string ShortUrlName { get; set; }

            /// <summary>
            /// <para>The short link status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>expired</b>: The short link has expired.</para>
            /// </description></item>
            /// <item><description><para><b>effective</b>: The short link is active.</para>
            /// </description></item>
            /// <item><description><para><b>audit</b>: The short link is under review.</para>
            /// </description></item>
            /// <item><description><para><b>reject</b>: The short link was rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>expired</para>
            /// </summary>
            [NameInMap("ShortUrlStatus")]
            [Validation(Required=false)]
            public string ShortUrlStatus { get; set; }

            /// <summary>
            /// <para>The source URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.****.com/product/sms">https://www.****.com/product/sms</a></para>
            /// </summary>
            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            /// <summary>
            /// <para>The unique visitor (UV) count for the short link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("UniqueVisitorCount")]
            [Validation(Required=false)]
            public string UniqueVisitorCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
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
