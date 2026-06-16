// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ListTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<ListTaskGroupResponseBodyResultObject> ResultObject { get; set; }
        public class ListTaskGroupResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588820785212</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>324253</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public long? CreatorUserId { get; set; }

            /// <summary>
            /// <para>Audience group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("GroupStatus")]
            [Validation(Required=false)]
            public string GroupStatus { get; set; }

            /// <summary>
            /// <para>Task group name.</para>
            /// </summary>
            [NameInMap("SampleNames")]
            [Validation(Required=false)]
            public List<string> SampleNames { get; set; }

            /// <summary>
            /// <para>Number of subtasks parsed and split from the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SubTaskCount")]
            [Validation(Required=false)]
            public int? SubTaskCount { get; set; }

            /// <summary>
            /// <para>Subtask.</para>
            /// </summary>
            [NameInMap("SubTaskList")]
            [Validation(Required=false)]
            public List<ListTaskGroupResponseBodyResultObjectSubTaskList> SubTaskList { get; set; }
            public class ListTaskGroupResponseBodyResultObjectSubTaskList : TeaModel {
                /// <summary>
                /// <para>Job end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-12 15:47:23</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>Group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pts-demo</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Indicates whether to hide.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HideViewResultButton")]
                [Validation(Required=false)]
                public bool? HideViewResultButton { get; set; }

                /// <summary>
                /// <para>Indicates whether the subtask is charged.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCharge")]
                [Validation(Required=false)]
                public bool? IsCharge { get; set; }

                /// <summary>
                /// <para>Model scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rfs</para>
                /// </summary>
                [NameInMap("ModelScene")]
                [Validation(Required=false)]
                public string ModelScene { get; set; }

                /// <summary>
                /// <para>Sample ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SampleId")]
                [Validation(Required=false)]
                public int? SampleId { get; set; }

                /// <summary>
                /// <para>Sample name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fs</para>
                /// </summary>
                [NameInMap("SampleName")]
                [Validation(Required=false)]
                public string SampleName { get; set; }

                /// <summary>
                /// <para>Service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anti_fraud_riskscreening</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>申请反欺诈V5（分值版）</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>Subtask ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SubTaskId")]
                [Validation(Required=false)]
                public int? SubTaskId { get; set; }

                /// <summary>
                /// <para>Indicates whether the job can be canceled. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description>true: The job can be canceled.  </description></item>
                /// <item><description>false: The job cannot be canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportCancel")]
                [Validation(Required=false)]
                public bool? SupportCancel { get; set; }

                /// <summary>
                /// <para>Supports download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportDownload")]
                [Validation(Required=false)]
                public bool? SupportDownload { get; set; }

                /// <summary>
                /// <para>Indicates whether merge download is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SupportMergeSelect")]
                [Validation(Required=false)]
                public bool? SupportMergeSelect { get; set; }

                /// <summary>
                /// <para>Indicates whether viewing is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportView")]
                [Validation(Required=false)]
                public bool? SupportView { get; set; }

                /// <summary>
                /// <para>Scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINANCE</para>
                /// </summary>
                [NameInMap("Tab")]
                [Validation(Required=false)]
                public string Tab { get; set; }

                /// <summary>
                /// <para>Task group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TaskGroupId")]
                [Validation(Required=false)]
                public int? TaskGroupId { get; set; }

                /// <summary>
                /// <para>The execution status of the import job:  </para>
                /// <list type="bullet">
                /// <item><description>DOING: running  </description></item>
                /// <item><description>FINISH: execution completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

            }

            /// <summary>
            /// <para>Scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <para>Task group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-uf62fwvw2f8dx88xo2lt</para>
            /// </summary>
            [NameInMap("TaskGroupId")]
            [Validation(Required=false)]
            public int? TaskGroupId { get; set; }

            /// <summary>
            /// <para>Task group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GroupTest</para>
            /// </summary>
            [NameInMap("TaskGroupName")]
            [Validation(Required=false)]
            public string TaskGroupName { get; set; }

        }

        /// <summary>
        /// <para>Total number of returned items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
