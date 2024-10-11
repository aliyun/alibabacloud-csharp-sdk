// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The quotas of the instance.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeQuotaResponseBodyResult Result { get; set; }
        public class DescribeQuotaResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The current QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("currentQps")]
            [Validation(Required=false)]
            public int? CurrentQps { get; set; }

            /// <summary>
            /// <para>The number of documents in the item table. Valid values:</para>
            /// <para>1000000 to 10000000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("itemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }

            /// <summary>
            /// <para>The number of items that are used in the item table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("itemCountUsed")]
            [Validation(Required=false)]
            public long? ItemCountUsed { get; set; }

            /// <summary>
            /// <para>The queries per second (QPS). Valid values:</para>
            /// <para>10 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("qps")]
            [Validation(Required=false)]
            public int? Qps { get; set; }

            /// <summary>
            /// <para>The number of documents in the user table. Valid values:</para>
            /// <para>1000000 to 10000000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("userCount")]
            [Validation(Required=false)]
            public long? UserCount { get; set; }

            /// <summary>
            /// <para>The number of users that are used in the user table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("userCountUsed")]
            [Validation(Required=false)]
            public long? UserCountUsed { get; set; }

        }

    }

}
