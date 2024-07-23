// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowExecutionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media workflows.</para>
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
                /// <para>The methods that are called in the media workflow.</para>
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
                        /// <para>The error code.</para>
                        /// <list type="bullet">
                        /// <item><description>This parameter is returned only if <b>Fail</b> is returned for the State parameter.</description></item>
                        /// <item><description>This parameter is not returned if the method status is <b>Success</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InvalidParameter.ResourceContentBad</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The time when the method ends.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-04-01T06:53:44Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The IDs of the jobs that are generated when the methods are called, such as the job IDs for the analysis, transcode, and snapshot methods.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2376030d9d0849399cd20e20f4f3****</para>
                        /// </summary>
                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        /// <summary>
                        /// <para>The message sent by Message Service (MNS) to notify the user of the job result.</para>
                        /// </summary>
                        [NameInMap("MNSMessageResult")]
                        [Validation(Required=false)]
                        public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult MNSMessageResult { get; set; }
                        public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionActivityListActivityMNSMessageResult : TeaModel {
                            /// <summary>
                            /// <para>The error code returned if the MNS message fails to be sent. This parameter is not returned if the MNS message is sent.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The Topic/Queue config is empty, not send message</para>
                            /// </summary>
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            /// <summary>
                            /// <para>The error message returned if the MNS message fails to be sent. This parameter is not returned if the MNS message is sent.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MessageConfigEmpty</para>
                            /// </summary>
                            [NameInMap("ErrorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The ID of the message that indicates the MNS message is sent. This parameter is not returned if the MNS message fails to be sent.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>4f3bc83233de4e2f81c7dade443e****</para>
                            /// </summary>
                            [NameInMap("MessageId")]
                            [Validation(Required=false)]
                            public string MessageId { get; set; }

                        }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// <list type="bullet">
                        /// <item><description>This parameter is returned only if <b>Fail</b> is returned for the State parameter.</description></item>
                        /// <item><description>This parameter is not returned if the method status is <b>Success</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The resource operated InputFile is bad</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>The name of the method.</para>
                        /// <remarks>
                        /// <para>The name of each method in a media workflow is unique.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Start</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The time when the method is called.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2016-04-01T06:53:44Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The status of the workflow method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Running: The method is being called.</description></item>
                        /// <item><description>Success: The method is called.</description></item>
                        /// <item><description>Fail: The method failed to be called.</description></item>
                        /// <item><description>Skipped: The method is skipped.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>For example, after the analysis is complete, the transcode method is called and high-definition and standard-definition transcoding jobs are created. The system determines whether to run the jobs based on the analysis result. If the resolution of the input video is low, the high-definition transcoding job may be skipped.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// <para>The methods that are supported in the media workflow. Valid values: Start, Snapshot, Transcode, Analysis, and Report. For more information, see <a href="https://help.aliyun.com/document_detail/68494.html">Methods supported for media workflows</a>.</para>
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
                /// <para>016-04-01T06:53:43Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The input data of the media workflow.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput Input { get; set; }
                public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInput : TeaModel {
                    /// <summary>
                    /// <para>The input file of the media workflow.</para>
                    /// </summary>
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile InputFile { get; set; }
                    public class QueryMediaWorkflowExecutionListResponseBodyMediaWorkflowExecutionListMediaWorkflowExecutionInputInputFile : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket in which the input file is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket-****</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The ID of the OSS region in which the input file resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mps-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The name of the OSS object that is used as the input file.</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// <para>The user-defined data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example data ****</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// <para>The ID of the media asset. A media file contains all the information about a media workflow.</para>
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
                /// <para>93ab850b4f6f44eab54b6e91****81d4</para>
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
                /// <item><description>Running: The media workflow is running.</description></item>
                /// <item><description>Completed: The media workflow is complete.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Completed only indicates that the media workflow is complete. View the status of each method in the workflow, such as the transcode and snapshot methods, to check whether the method is called.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>Fail: The media workflow fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the execution instances that do not exist.</para>
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
