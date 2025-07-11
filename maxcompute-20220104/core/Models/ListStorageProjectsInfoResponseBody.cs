// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStorageProjectsInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStorageProjectsInfoResponseBodyData Data { get; set; }
        public class ListStorageProjectsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("storageProjectInfoList")]
            [Validation(Required=false)]
            public List<ListStorageProjectsInfoResponseBodyDataStorageProjectInfoList> StorageProjectInfoList { get; set; }
            public class ListStorageProjectsInfoResponseBodyDataStorageProjectInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20250528</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("longTermStorage")]
                [Validation(Required=false)]
                public double? LongTermStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("longTermStorageUnit")]
                [Validation(Required=false)]
                public string LongTermStorageUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("lowFreqStorage")]
                [Validation(Required=false)]
                public double? LowFreqStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("lowFreqStorageUnit")]
                [Validation(Required=false)]
                public string LowFreqStorageUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>max_testproject</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.011872406445069006</para>
                /// </summary>
                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("recycleBinStorage")]
                [Validation(Required=false)]
                public double? RecycleBinStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("recycleBinStorageUnit")]
                [Validation(Required=false)]
                public string RecycleBinStorageUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("standardStorage")]
                [Validation(Required=false)]
                public double? StandardStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("standardStorageUnit")]
                [Validation(Required=false)]
                public string StandardStorageUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1749105045512</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalStorage")]
                [Validation(Required=false)]
                public double? TotalStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TB</para>
                /// </summary>
                [NameInMap("totalStorageUnit")]
                [Validation(Required=false)]
                public string TotalStorageUnit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc3b4b016674434996033675e71ee</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
