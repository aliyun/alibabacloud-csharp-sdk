// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The batch information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyData Data { get; set; }
        public class DescribePipelineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the change order for the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("CoStatus")]
            [Validation(Required=false)]
            public string CoStatus { get; set; }

            /// <summary>
            /// <para>The ID of the batch processing stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c3a55592-4c30-4d84-ac2d-e98c18ec****</para>
            /// </summary>
            [NameInMap("CurrentStageId")]
            [Validation(Required=false)]
            public string CurrentStageId { get; set; }

            /// <summary>
            /// <para>The ID of the next batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b77b1c98-5772-4f05-95fc-c7bee5fa****</para>
            /// </summary>
            [NameInMap("NextPipelineId")]
            [Validation(Required=false)]
            public string NextPipelineId { get; set; }

            /// <summary>
            /// <para>The ID of the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>917660ba-5092-44ca-b8e0-80012c96****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The name of the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>First batch</para>
            /// </summary>
            [NameInMap("PipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            /// <summary>
            /// <para>The batch status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The batch is prepared for processing.</description></item>
            /// <item><description><b>1</b>: The task is being executed.</description></item>
            /// <item><description><b>2</b>: successful</description></item>
            /// <item><description><b>3</b>: The processing failed in this stage.</description></item>
            /// <item><description><b>6</b>: The batch processing was terminated.</description></item>
            /// <item><description><b>10</b>: The batch could not be processed due to a system exception.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PipelineStatus")]
            [Validation(Required=false)]
            public int? PipelineStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether to start processing the next batch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: indicates that the next batch cannot be processed yet.</description></item>
            /// <item><description><b>true</b>: indicates that the next batch can be processed now.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ShowBatch")]
            [Validation(Required=false)]
            public bool? ShowBatch { get; set; }

            /// <summary>
            /// <para>The list of batch processing stages.</para>
            /// </summary>
            [NameInMap("StageList")]
            [Validation(Required=false)]
            public List<DescribePipelineResponseBodyDataStageList> StageList { get; set; }
            public class DescribePipelineResponseBodyDataStageList : TeaModel {
                /// <summary>
                /// <para>The execution type of the stage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: in sequence.</description></item>
                /// <item><description><b>1</b>: in parallel.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExecutorType")]
                [Validation(Required=false)]
                public int? ExecutorType { get; set; }

                /// <summary>
                /// <para>The ID of the stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c3a55592-4c30-4d84-ac2d-e98c18ec****</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// <para>The name of the stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deploy an application</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// <para>The status of the batch processing stage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The batch is prepared for this processing stage.</description></item>
                /// <item><description><b>1</b>: The task is being executed.</description></item>
                /// <item><description><b>2</b>: successful</description></item>
                /// <item><description><b>3</b>: The processing failed in this stage.</description></item>
                /// <item><description><b>6</b>: The processing stage was terminated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The list of task statuses.</para>
                /// </summary>
                [NameInMap("TaskList")]
                [Validation(Required=false)]
                public List<DescribePipelineResponseBodyDataStageListTaskList> TaskList { get; set; }
                public class DescribePipelineResponseBodyDataStageListTaskList : TeaModel {
                    /// <summary>
                    /// <para>The error code returned when the task could not be executed. If the task is successfully executed, this parameter is not returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EDAS-10022</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to execute the subsequent tasks when the task failed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The subsequent tasks cannot be executed.</description></item>
                    /// <item><description><b>1</b>: The subsequent tasks can be executed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorIgnore")]
                    [Validation(Required=false)]
                    public int? ErrorIgnore { get; set; }

                    /// <summary>
                    /// <para>The error message returned when the task could not be executed. If the task is successfully executed, this parameter is not returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EDAS-10022</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The returned message indicating the task execution result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>init Namespace success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a running task can be manually skipped. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The running task can be skipped.</description></item>
                    /// <item><description><b>false</b>: The zone does not allow you to change the network type of an ApsaraDB for Redis instance from classic network to VPC.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ShowManualIgnore")]
                    [Validation(Required=false)]
                    public bool? ShowManualIgnore { get; set; }

                    /// <summary>
                    /// <para>The ID of the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c3a55592-4c30-4d84-ac2d-e98c18ec****</para>
                    /// </summary>
                    [NameInMap("StageId")]
                    [Validation(Required=false)]
                    public string StageId { get; set; }

                    /// <summary>
                    /// <para>The task status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The task is prepared for execution.</description></item>
                    /// <item><description><b>1</b>: The task is being executed.</description></item>
                    /// <item><description><b>2</b>: successful</description></item>
                    /// <item><description><b>3</b>: The task could not be executed.</description></item>
                    /// <item><description><b>5</b>: The task is pending retry.</description></item>
                    /// <item><description><b>6</b>: The task was terminated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bef0122f-de9a-4ab0-8223-b88bf8ad****</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// <para>The name of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Environment initialization</para>
                    /// </summary>
                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned if the request succeeds.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>559B4247-C41C-4D9E-B866-B55D360B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the batch information was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was queried.</description></item>
        /// <item><description><b>false</b>: The image failed to be found.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0c316390414649128666e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
