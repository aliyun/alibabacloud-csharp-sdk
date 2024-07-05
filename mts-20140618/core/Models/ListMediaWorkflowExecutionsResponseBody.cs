// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaWorkflowExecutionsResponseBody : TeaModel {
        /// <summary>
        /// The details of the media workflows.
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
                /// The activities that are executed in the media workflow.
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
                        /// The error code returned if the request failed.
                        /// 
                        /// *   The specific error code appears if the state of the activity is **Fail**.
                        /// *   This parameter is not returned if the state of the activity is **Success**.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The end time of the activity.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The ID of the job generated when the activity is executed. We recommend that you keep this ID for subsequent operation calls.
                        /// </summary>
                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        /// <summary>
                        /// The message sent by Message Service (MNS) to notify the user of the job result.
                        /// </summary>
                        [NameInMap("MNSMessageResult")]
                        [Validation(Required=false)]
                        public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
                            /// <summary>
                            /// The error code returned if the job failed. If the job was successful, this parameter is not returned.
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// The error message returned if the job failed. If the job was successful, this parameter is not returned.
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// The ID of the success message. If the job failed, this parameter is not returned.
                            /// </summary>
                            [NameInMap("MessageId")]
                            [Validation(Required=false)]
                            public string MessageId { get; set; }

                        }

                        /// <summary>
                        /// The error message returned if the request failed.
                        /// 
                        /// *   The detailed error message appears if the state of the activity is **Fail**.
                        /// *   This parameter is not returned if the state of the activity is **Success**.
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// The name of the media workflow activity.
                        /// 
                        /// > The name of an activity in a media workflow is unique.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The start time of the activity.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The status of the activity. Valid values:
                        /// 
                        /// *   **Running**: The activity is being executed.
                        /// *   **Fail**: The activity failed to be executed.
                        /// *   **Skipped**: The activity was skipped.
                        /// *   **Success**: The activity was successfully executed.
                        /// 
                        /// > For example, the high-definition and standard-definition transcoding activities are to be run after the analysis activity is complete. The system determines the activity to run based on the analysis result. If the definition of the input video content is insufficient, the high-definition transcoding activity may be skipped.
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// The type of the media workflow activity. Valid values: Start, Snapshot, Transcode, Analysis, and Report. For more information, see [Methods supported for media workflows](https://help.aliyun.com/document_detail/68494.html).
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The time when the media workflow was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The custom data of the media workflow.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    /// <summary>
                    /// The information about the storage location of the input file of the media workflow in OSS.
                    /// </summary>
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class ListMediaWorkflowExecutionsResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
                        /// <summary>
                        /// The name of the OSS bucket in which the input media file is stored.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The OSS region in which the input file resides.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The name of the OSS object that is used as the input media file.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// The custom data.
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// The ID of the media file. A media file contains all the information about a media workflow.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The ID of the media workflow.
                /// </summary>
                [NameInMap("MediaWorkflowId")]
                [Validation(Required=false)]
                public string MediaWorkflowId { get; set; }

                /// <summary>
                /// The name of the media workflow.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the execution instance.
                /// </summary>
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// The status of the media workflow. Valid values:
                /// 
                /// *   **running**: The execution is in progress.
                /// *   **Completed**: The execution is complete.
                /// 
                /// > A value of Completed indicates that the execution is complete. For the information about whether each activity, such as Transcode or Snapshot, is successful, check the status of the activity.
                /// 
                /// *   **Fail**: The execution failed.
                /// *   **Success**: The execution was successful.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
