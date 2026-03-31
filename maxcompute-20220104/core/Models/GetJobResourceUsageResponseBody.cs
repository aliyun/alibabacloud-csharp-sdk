// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetJobResourceUsageResponseBodyData Data { get; set; }
        public class GetJobResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list returned.</para>
            /// </summary>
            [NameInMap("jobResourceUsageList")]
            [Validation(Required=false)]
            public List<GetJobResourceUsageResponseBodyDataJobResourceUsageList> JobResourceUsageList { get; set; }
            public class GetJobResourceUsageResponseBodyDataJobResourceUsageList : TeaModel {
                /// <summary>
                /// <para>The total number of used compute units (CUs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1185100</para>
                /// </summary>
                [NameInMap("cuUsage")]
                [Validation(Required=false)]
                public long? CuUsage { get; set; }

                /// <summary>
                /// <para>The start date of the query in the format of yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-09</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The job executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$<a href="mailto:xxx@test.aliyunid.com">xxx@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// <para>The total memory usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15169536</para>
                /// </summary>
                [NameInMap("memoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                /// <summary>
                /// <para>The quota nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_quota</para>
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A3B1E82006A23A918C70905BF08AEC7</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b57ff7616612271051086500ea3ce</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
