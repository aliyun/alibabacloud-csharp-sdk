// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillSplitGetResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The split monthly billing information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<MonthBillSplitGetResponseBodyModule> Module { get; set; }
        public class MonthBillSplitGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The key of the bill split dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invoice_third_part_id123</para>
            /// </summary>
            [NameInMap("bill_split_key")]
            [Validation(Required=false)]
            public string BillSplitKey { get; set; }

            /// <summary>
            /// <para>The end date of the billing period.</para>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-31</para>
            /// </summary>
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The start date of the billing period.</para>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-01</para>
            /// </summary>
            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The download link for the bill data. Retrieve the data by using HttpClient and parse it in GBK encoding.</para>
            /// <list type="bullet">
            /// <item><description>The data is in JSON format.</description></item>
            /// <item><description>The link is valid for 5 minutes.</description></item>
            /// <item><description>For object descriptions, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5037134">Alibaba Business Travel bill object overview</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alibtrip-oss.oss-cn-hangzhou.aliyuncs.com/">https://alibtrip-oss.oss-cn-hangzhou.aliyuncs.com/</a>********</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-<b><b>-</b></b>-****-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
