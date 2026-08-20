// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeApiMeteringResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>fatal</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Fatal")]
        [Validation(Required=false)]
        public bool? Fatal { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;成功&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62FC432C55A1A63534A6CB34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeApiMeteringResponseBodyResult> Result { get; set; }
        public class DescribeApiMeteringResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102277855749****</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public long? AliyunPk { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmapi0004****</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>身份证实名认证-身份证实名</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public long? TotalCapacity { get; set; }

            /// <summary>
            /// <para>The remaining quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <para>The usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public long? TotalUsage { get; set; }

            /// <summary>
            /// <para>The unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>次</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
