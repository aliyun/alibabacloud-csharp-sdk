// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowExecutionListResponseBody : TeaModel {
        /// <summary>
        /// The details of the media workflows.
        /// </summary>
        [NameInMap("MediaWorkflowExecutionList")]
        [Validation(Required=false)]
        public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionList MediaWorkflowExecutionList { get; set; }
        public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionList : TeaModel {
            [NameInMap("MediaWorkflowExecution")]
            [Validation(Required=false)]
            public List<QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution> MediaWorkflowExecution { get; set; }
            public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecution : TeaModel {
                /// <summary>
                /// The methods that are called in the media workflow.
                /// </summary>
                [NameInMap("ActivityList")]
                [Validation(Required=false)]
                public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList ActivityList { get; set; }
                public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityList : TeaModel {
                    [NameInMap("Activity")]
                    [Validation(Required=false)]
                    public List<QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity> Activity { get; set; }
                    public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivity : TeaModel {
                        /// <summary>
                        /// The error code.
                        /// 
                        /// *   This parameter is returned only if **Fail** is returned for the State parameter.
                        /// *   This parameter is not returned if the method status is **Success**.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The time when the method ends.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The IDs of the jobs that are generated when the methods are called, such as the job IDs for the analysis, transcode, and snapshot methods.
                        /// </summary>
                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        /// <summary>
                        /// The message sent by Message Service (MNS) to notify the user of the job result.
                        /// </summary>
                        [NameInMap("MNSMessageResult")]
                        [Validation(Required=false)]
                        public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
                            /// <summary>
                            /// The error code returned if the MNS message fails to be sent. This parameter is not returned if the MNS message is sent.
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// The error message returned if the MNS message fails to be sent. This parameter is not returned if the MNS message is sent.
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// The ID of the message that indicates the MNS message is sent. This parameter is not returned if the MNS message fails to be sent.
                            /// </summary>
                            [NameInMap("MessageId")]
                            [Validation(Required=false)]
                            public string MessageId { get; set; }

                        }

                        /// <summary>
                        /// The error message.
                        /// 
                        /// *   This parameter is returned only if **Fail** is returned for the State parameter.
                        /// *   This parameter is not returned if the method status is **Success**.
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// The name of the method.
                        /// 
                        /// > The name of each method in a media workflow is unique.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The time when the method is called.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The status of the workflow method. Valid values:
                        /// 
                        /// *   Running: The method is being called.
                        /// *   Success: The method is called.
                        /// *   Fail: The method failed to be called.
                        /// *   Skipped: The method is skipped.
                        /// 
                        /// > For example, after the analysis is complete, the transcode method is called and high-definition and standard-definition transcoding jobs are created. The system determines whether to run the jobs based on the analysis result. If the resolution of the input video is low, the high-definition transcoding job may be skipped.
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// The methods that are supported in the media workflow. Valid values: Start, Snapshot, Transcode, Analysis, and Report. For more information, see [Methods supported for media workflows](https://help.aliyun.com/document_detail/68494.html).
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
                /// The input data of the media workflow.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    /// <summary>
                    /// The input file of the media workflow.
                    /// </summary>
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
                        /// <summary>
                        /// The name of the OSS bucket in which the input file is stored.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The ID of the OSS region in which the input file resides.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The name of the OSS object that is used as the input file.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// The user-defined data.
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// The ID of the media asset. A media file contains all the information about a media workflow.
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
                /// *   Running: The media workflow is running.
                /// *   Completed: The media workflow is complete.
                /// 
                /// > Completed only indicates that the media workflow is complete. View the status of each method in the workflow, such as the transcode and snapshot methods, to check whether the method is called.
                /// 
                /// *   Fail: The media workflow fails.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the execution instances that do not exist.
        /// </summary>
        [NameInMap("NonExistRunIds")]
        [Validation(Required=false)]
        public QueryMediaWorkflowExecutionListResponseBodyNonExistRunIds NonExistRunIds { get; set; }
        public class QueryMediaWorkflowExecutionListResponseBodyNonExistRunIds : TeaModel {
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public List<string> RunId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
