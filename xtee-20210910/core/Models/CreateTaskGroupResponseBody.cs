// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CreateTaskGroupResponseBodyResultObject ResultObject { get; set; }
        public class CreateTaskGroupResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1750645267000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>345298</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public int? CreatorUserId { get; set; }

            /// <summary>
            /// <para>The group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("GroupStatus")]
            [Validation(Required=false)]
            public string GroupStatus { get; set; }

            /// <summary>
            /// <para>The task group name.</para>
            /// </summary>
            [NameInMap("SampleNames")]
            [Validation(Required=false)]
            public List<string> SampleNames { get; set; }

            /// <summary>
            /// <para>The number of subtasks generated from task parsing and splitting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SubTaskCount")]
            [Validation(Required=false)]
            public int? SubTaskCount { get; set; }

            /// <summary>
            /// <para>The subtask list.</para>
            /// </summary>
            [NameInMap("SubTaskList")]
            [Validation(Required=false)]
            public List<CreateTaskGroupResponseBodyResultObjectSubTaskList> SubTaskList { get; set; }
            public class CreateTaskGroupResponseBodyResultObjectSubTaskList : TeaModel {
                /// <summary>
                /// <para>The reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>303872</para>
                /// </summary>
                [NameInMap("Checker")]
                [Validation(Required=false)]
                public string Checker { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model_test_enorl_202606040953+10.csv</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The number of rows in the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("FileRows")]
                [Validation(Required=false)]
                public string FileRows { get; set; }

                /// <summary>
                /// <para>The task end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-12 15:47:23</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pts-demo</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is billed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCharge")]
                [Validation(Required=false)]
                public string IsCharge { get; set; }

                /// <summary>
                /// <para>The model scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rfs</para>
                /// </summary>
                [NameInMap("ModelScene")]
                [Validation(Required=false)]
                public string ModelScene { get; set; }

                /// <summary>
                /// <para>The sample IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SampleId")]
                [Validation(Required=false)]
                public string SampleId { get; set; }

                /// <summary>
                /// <para>The sample name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fs</para>
                /// </summary>
                [NameInMap("SampleName")]
                [Validation(Required=false)]
                public string SampleName { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anti_fraud_customed</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>多头风险前筛</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The subtask ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SubTaskId")]
                [Validation(Required=false)]
                public long? SubTaskId { get; set; }

                /// <summary>
                /// <para>The scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINANCE</para>
                /// </summary>
                [NameInMap("Tab")]
                [Validation(Required=false)]
                public string Tab { get; set; }

                /// <summary>
                /// <para>The task group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TaskGroupId")]
                [Validation(Required=false)]
                public string TaskGroupId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里多头_68629_20260115</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The execution status of the import task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DOING: Running.</description></item>
                /// <item><description>FINISH: Completed.</description></item>
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
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <para>The task group ID.</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview. When this parameter is used, other query conditions become invalid.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>g-0jlcreertd0p471l6f72</para>
            /// </summary>
            [NameInMap("TaskGroupId")]
            [Validation(Required=false)]
            public int? TaskGroupId { get; set; }

            /// <summary>
            /// <para>The task group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GroupTest</para>
            /// </summary>
            [NameInMap("TaskGroupName")]
            [Validation(Required=false)]
            public string TaskGroupName { get; set; }

        }

    }

}
