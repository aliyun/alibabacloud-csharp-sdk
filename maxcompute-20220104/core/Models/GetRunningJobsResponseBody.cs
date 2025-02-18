// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRunningJobsResponseBodyData Data { get; set; }
        public class GetRunningJobsResponseBodyData : TeaModel {
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
            /// <para>The list of jobs in the running state.</para>
            /// </summary>
            [NameInMap("runningJobInfoList")]
            [Validation(Required=false)]
            public List<GetRunningJobsResponseBodyDataRunningJobInfoList> RunningJobInfoList { get; set; }
            public class GetRunningJobsResponseBodyDataRunningJobInfoList : TeaModel {
                /// <summary>
                /// <para>The compute unit (CU) snapshot proportion of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.45</para>
                /// </summary>
                [NameInMap("cuSnapshot")]
                [Validation(Required=false)]
                public double? CuSnapshot { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023050206371544gomgtp3ljcr4</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The account that submits the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$<a href="mailto:xxx@test.aliyunid.com">xxx@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// <para>The memory snapshot proportion of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.45</para>
                /// </summary>
                [NameInMap("memorySnapshot")]
                [Validation(Required=false)]
                public double? MemorySnapshot { get; set; }

                /// <summary>
                /// <para>The progress of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public double? Progress { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_20221021123044_981b</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The nickname of the quota that is used by the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_quota</para>
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

                /// <summary>
                /// <para>The time when the job starts to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1689746864</para>
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// <para>The time when the job is submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1689746864</para>
                /// </summary>
                [NameInMap("submittedAtTime")]
                [Validation(Required=false)]
                public long? SubmittedAtTime { get; set; }

            }

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
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error code was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A3B1FD2006A24C8D8BE65CDAC028298</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3b4ab16684833172127321e2c25</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
