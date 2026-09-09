// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStorageProjectsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStorageProjectsInfoResponseBodyData Data { get; set; }
        public class ListStorageProjectsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The statistics collection date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

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
            /// <para>The number of entries on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The list of project-level storage information.</para>
            /// </summary>
            [NameInMap("storageProjectInfoList")]
            [Validation(Required=false)]
            public List<ListStorageProjectsInfoResponseBodyDataStorageProjectInfoList> StorageProjectInfoList { get; set; }
            public class ListStorageProjectsInfoResponseBodyDataStorageProjectInfoList : TeaModel {
                /// <summary>
                /// <para>The statistics collection date. The date is accurate to the day. The date must be in the <c>YYYYMMdd</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20250528</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The Long Term storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("longTermStorage")]
                [Validation(Required=false)]
                public double? LongTermStorage { get; set; }

                /// <summary>
                /// <para>The unit of the Long Term storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("longTermStorageUnit")]
                [Validation(Required=false)]
                public string LongTermStorageUnit { get; set; }

                /// <summary>
                /// <para>The IA storage class usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("lowFreqStorage")]
                [Validation(Required=false)]
                public double? LowFreqStorage { get; set; }

                /// <summary>
                /// <para>The unit of the IA storage class usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("lowFreqStorageUnit")]
                [Validation(Required=false)]
                public string LowFreqStorageUnit { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>max_testproject</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The year-over-year change rate of the total storage usage in the last {$recentDays} days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.011872406445069006</para>
                /// </summary>
                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                /// <summary>
                /// <para>The recycle bin storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("recycleBinStorage")]
                [Validation(Required=false)]
                public double? RecycleBinStorage { get; set; }

                /// <summary>
                /// <para>The unit of the recycle bin storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("recycleBinStorageUnit")]
                [Validation(Required=false)]
                public string RecycleBinStorageUnit { get; set; }

                /// <summary>
                /// <para>The Standard storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("standardStorage")]
                [Validation(Required=false)]
                public double? StandardStorage { get; set; }

                /// <summary>
                /// <para>The unit of the Standard storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("standardStorageUnit")]
                [Validation(Required=false)]
                public string StandardStorageUnit { get; set; }

                /// <summary>
                /// <para>The timestamp of the last data update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1749105045512</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The total storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalStorage")]
                [Validation(Required=false)]
                public double? TotalStorage { get; set; }

                /// <summary>
                /// <para>The unit of the total storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TB</para>
                /// </summary>
                [NameInMap("totalStorageUnit")]
                [Validation(Required=false)]
                public string TotalStorageUnit { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: an informational response. The request has been received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: a success response. The request has been successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: a redirection response. The request is redirected. You must take further action to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: a client error. The request contains invalid request parameters or syntax, or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: a server error. The server fails to fulfill the request for other reasons.</para>
        /// </description></item>
        /// </list>
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
        /// <para>0bc3b4b016674434996033675e71ee</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
