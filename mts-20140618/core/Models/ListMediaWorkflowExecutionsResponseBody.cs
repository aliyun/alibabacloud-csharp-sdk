// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaWorkflowExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media workflows.</para>
        /// </summary>
        [NameInMap("MediaWorkflowExecutionList")]
        [Validation(Required=false)]
        public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionList MediaWorkflowExecutionList { get; set; }
        public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionList : TeaModel {
            [NameInMap("MediaWorkflowExecution")]
            [Validation(Required=false)]
            public List<ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution> MediaWorkflowExecution { get; set; }
            public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution : TeaModel {
                /// <summary>
                /// <para>The activities that are executed in the media workflow.</para>
                /// </summary>
                [NameInMap("ActivityList")]
                [Validation(Required=false)]
                public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList ActivityList { get; set; }
                public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList : TeaModel {
                    [NameInMap("Activity")]
                    [Validation(Required=false)]
                    public List<ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity> Activity { get; set; }
                    public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity : TeaModel {
                        /// <summary>
                        /// <para>The error code returned if the request failed.</para>
                        /// <list type="bullet">
                        /// <item><description>The specific error code appears if the state of the activity is <b>Fail</b>.</description></item>
                        /// <item><description>This parameter is not returned if the state of the activity is <b>Success</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The end time of the activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-04-01T06:54:00Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the job generated when the activity is executed. We recommend that you keep this ID for subsequent operation calls.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2376030d9d0849399cd20e20c876****</para>
                        /// </summary>
                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        /// <summary>
                        /// <para>The message sent by Message Service (MNS) to notify the user of the job result.</para>
                        /// </summary>
                        [NameInMap("MNSMessageResult")]
                        [Validation(Required=false)]
                        public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
                            /// <summary>
                            /// <para>The error code returned if the job failed. If the job was successful, this parameter is not returned.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The Topic/Queue config is empty, not send message</para>
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// <para>The error message returned if the job failed. If the job was successful, this parameter is not returned.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MessageConfigEmpty</para>
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The ID of the success message. If the job failed, this parameter is not returned.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>4f3bc83233de4e2f81c7dade443e****</para>
                            /// </summary>
                            [NameInMap("MessageId")]
                            [Validation(Required=false)]
                            public string MessageId { get; set; }

                        }

                        /// <summary>
                        /// <para>The error message returned if the request failed.</para>
                        /// <list type="bullet">
                        /// <item><description>The detailed error message appears if the state of the activity is <b>Fail</b>.</description></item>
                        /// <item><description>This parameter is not returned if the state of the activity is <b>Success</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>The name of the media workflow activity.</para>
                        /// <remarks>
                        /// <para>The name of an activity in a media workflow is unique.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Act-2</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The start time of the activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-04-01T06:53:45Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The status of the activity. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Running</b>: The activity is being executed.</description></item>
                        /// <item><description><b>Fail</b>: The activity failed to be executed.</description></item>
                        /// <item><description><b>Skipped</b>: The activity was skipped.</description></item>
                        /// <item><description><b>Success</b>: The activity was successfully executed.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>For example, the high-definition and standard-definition transcoding activities are to be run after the analysis activity is complete. The system determines the activity to run based on the analysis result. If the definition of the input video content is insufficient, the high-definition transcoding activity may be skipped.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Success</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// <para>The type of the media workflow activity. Valid values: Start, Snapshot, Transcode, Analysis, and Report. For more information, see <a href="https://help.aliyun.com/document_detail/68494.html">Methods supported for media workflows</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Start</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the media workflow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-04-01T06:53:43Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The custom data of the media workflow.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    /// <summary>
                    /// <para>The information about the storage location of the input file of the media workflow in OSS.</para>
                    /// </summary>
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket in which the input media file is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket-****</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The OSS region in which the input file resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The name of the OSS object that is used as the input media file.</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// <para>The custom data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example data</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// <para>The ID of the media file. A media file contains all the information about a media workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512046582a924698a41e0f8b0d2b****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The ID of the media workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43b7335a4b1d4fe883670036affb****</para>
                /// </summary>
                [NameInMap("MediaWorkflowId")]
                [Validation(Required=false)]
                public string MediaWorkflowId { get; set; }

                /// <summary>
                /// <para>The name of the media workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-mediaworkflow-****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the execution instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48e33690ac19445488c706924321****</para>
                /// </summary>
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// <para>The status of the media workflow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>running</b>: The execution is in progress.</description></item>
                /// <item><description><b>Completed</b>: The execution is complete.</description></item>
                /// </list>
                /// <remarks>
                /// <para>A value of Completed indicates that the execution is complete. For the information about whether each activity, such as Transcode or Snapshot, is successful, check the status of the activity.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>Fail</b>: The execution failed.</description></item>
                /// <item><description><b>Success</b>: The execution was successful.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1D5C080-8E2F-5030-8AB4-13092F17631B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
