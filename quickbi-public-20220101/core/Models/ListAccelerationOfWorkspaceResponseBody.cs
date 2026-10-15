// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListAccelerationOfWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E****************05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The acceleration task information model.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAccelerationOfWorkspaceResponseBodyResult Result { get; set; }
        public class ListAccelerationOfWorkspaceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The array of acceleration task information.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAccelerationOfWorkspaceResponseBodyResultData> Data { get; set; }
            public class ListAccelerationOfWorkspaceResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d14e*********fef8de29fd</para>
                /// </summary>
                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                /// <summary>
                /// <para>The dataset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CubeName")]
                [Validation(Required=false)]
                public string CubeName { get; set; }

                /// <summary>
                /// <para>The time when acceleration was enabled, in the format of YYYYMMDD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20250911 00:00:00</para>
                /// </summary>
                [NameInMap("EnableQuickindexTime")]
                [Validation(Required=false)]
                public string EnableQuickindexTime { get; set; }

                /// <summary>
                /// <para>The task history ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QWDAASG*******8SAD</para>
                /// </summary>
                [NameInMap("JobHistoryId")]
                [Validation(Required=false)]
                public string JobHistoryId { get; set; }

                /// <summary>
                /// <para>The acceleration task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b30b74**********b3b</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: pending</description></item>
                /// <item><description>1: running</description></item>
                /// <item><description>2: completed</description></item>
                /// <item><description>3: failed</description></item>
                /// <item><description>4: canceled</description></item>
                /// <item><description>5: warning</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public int? JobStatus { get; set; }

                /// <summary>
                /// <para>The last modification time, in the format of YYYYMMDD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20250911 00:00:00</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <para>The size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47045632</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>The next page number. A value of NULL or 0 indicates that there is no next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public int? Next { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The previous page number. A value of NULL or 0 indicates that there is no previous page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Pre")]
            [Validation(Required=false)]
            public int? Pre { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
