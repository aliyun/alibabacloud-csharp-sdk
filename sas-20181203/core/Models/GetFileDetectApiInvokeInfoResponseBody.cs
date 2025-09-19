// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectApiInvokeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Returns the response body.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectApiInvokeInfoResponseBodyData Data { get; set; }
        public class GetFileDetectApiInvokeInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public long? AuthCount { get; set; }

            /// <summary>
            /// <para>The total number of authorizations(excluding trials).</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AuthCountInSaleVersion")]
            [Validation(Required=false)]
            public long? AuthCountInSaleVersion { get; set; }

            /// <summary>
            /// <para>The timestamp of the expiration date of the authorization number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1815753600000</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <para>The frequency of calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FlowRate")]
            [Validation(Required=false)]
            public int? FlowRate { get; set; }

            /// <summary>
            /// <para>The number of authorizations used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InvokeCount")]
            [Validation(Required=false)]
            public long? InvokeCount { get; set; }

            /// <summary>
            /// <para>The number of authorizations used(excluding trials).</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("InvokeCountInSaleVersion")]
            [Validation(Required=false)]
            public long? InvokeCountInSaleVersion { get; set; }

            /// <summary>
            /// <para>The number of remaining authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("RemainAuthCount")]
            [Validation(Required=false)]
            public long? RemainAuthCount { get; set; }

            /// <summary>
            /// <para>The Authorized Version. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><b>1:</b> trial version</description></item>
            /// <item><description><b>2:</b> Enterprise Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public int? SaleVersion { get; set; }

            /// <summary>
            /// <para>The time unit of the frequency limit. Value:</para>
            /// <list type="bullet">
            /// <item><description><b>SECONDS</b></description></item>
            /// <item><description><b>MINUTES</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SECONDS</para>
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f368b6e-d60a-43c5-bd6f-c7087f2d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
