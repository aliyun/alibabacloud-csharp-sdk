// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPagedInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPagedInstanceResponseBodyData Data { get; set; }
        public class GetPagedInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the task.</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<GetPagedInstanceResponseBodyDataInstance> Instance { get; set; }
            public class GetPagedInstanceResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the task node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-14 16:00:57</para>
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                /// <summary>
                /// <para>The state of archived data verification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The verification was successful.</description></item>
                /// <item><description><b>1</b>: Inconsistent data was detected.</description></item>
                /// <item><description><b>2</b>: The verification was not performed.</description></item>
                /// <item><description><b>3</b>: The verification is in progress.</description></item>
                /// <item><description><b>4</b>: The verification was interrupted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public long? CheckStatus { get; set; }

                /// <summary>
                /// <para>The unique ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33753</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// <para>Indicates whether the source data is deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: deletes the jobs in the application group.</description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Delete")]
                [Validation(Required=false)]
                public string Delete { get; set; }

                /// <summary>
                /// <para>The time when the task ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-23 10:23:20</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The time when the task flow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-28 10:50:45</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the task flow was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-18 15:28:16</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the historical task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6851</para>
                /// </summary>
                [NameInMap("HistoryDagId")]
                [Validation(Required=false)]
                public long? HistoryDagId { get; set; }

                /// <summary>
                /// <para>The task flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24271</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The context of the last execution of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{”nodes&quot;:[11694,11695]&quot;}</para>
                /// </summary>
                [NameInMap("LastRunningContext")]
                [Validation(Required=false)]
                public string LastRunningContext { get; set; }

                /// <summary>
                /// <para>The details of the current task execution.</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The state of the archiving task.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Pending.</description></item>
                /// <item><description><b>1</b>: Running.</description></item>
                /// <item><description><b>2</b>: Paused.</description></item>
                /// <item><description><b>3</b>: Failed.</description></item>
                /// <item><description><b>4</b>: Succeeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: data archiving</description></item>
                /// <item><description><b>2</b>: archived data restoration</description></item>
                /// <item><description><b>3</b>: archived data verification</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public long? TaskType { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3406</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The mode in which the task flow is triggered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task flow was triggered based on a schedule.</description></item>
                /// <item><description><b>1</b>: The task flow was manually triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public long? TriggerType { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FAD400F-7A5C-4193-8F9A-39D86C4F0231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The trace ID, which is used to track the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06e1e316757357507896067d3780</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
