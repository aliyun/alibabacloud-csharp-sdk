// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class SendNapalStreamMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>This field is mutually exclusive with Task, TaskStatusUpdate, and TaskArtifactUpdate. When this field is returned, no task is created, and the stream closes after sending one Message. This API does not currently return this type. This field is reserved for protocol compatibility only.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public SendNapalStreamMessageResponseBodyMessage Message { get; set; }
        public class SendNapalStreamMessageResponseBodyMessage : TeaModel {
            /// <summary>
            /// <para>The session context ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context-07b0**bcc2</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>Reserved field. This parameter is not returned by the current operation.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public List<string> Extensions { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>message-fd6e**9949</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>Reserved field. This parameter is not returned by the current operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The list of message content parts.</para>
            /// </summary>
            [NameInMap("Parts")]
            [Validation(Required=false)]
            public List<SendNapalStreamMessageResponseBodyMessageParts> Parts { get; set; }
            public class SendNapalStreamMessageResponseBodyMessageParts : TeaModel {
                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reserved.bin</para>
                /// </summary>
                [NameInMap("Filename")]
                [Validation(Required=false)]
                public string Filename { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/octet-stream</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmVzZXJ2ZWQ=</para>
                /// </summary>
                [NameInMap("Raw")]
                [Validation(Required=false)]
                public string Raw { get; set; }

                /// <summary>
                /// <para>The text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The current instance is running normally</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Reserved field. This parameter is not returned by the current operation.</para>
            /// </summary>
            [NameInMap("ReferenceTaskIds")]
            [Validation(Required=false)]
            public List<string> ReferenceTaskIds { get; set; }

            /// <summary>
            /// <para>The message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Reserved field. A directly returned Message does not create a task, so this field is empty. This API does not currently return a top-level Message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-reserved</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public SendNapalStreamMessageResponseBodyTask Task { get; set; }
        public class SendNapalStreamMessageResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The list of task artifacts.</para>
            /// </summary>
            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public List<SendNapalStreamMessageResponseBodyTaskArtifacts> Artifacts { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskArtifacts : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>output</para>
                /// </summary>
                [NameInMap("ArtifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                /// <summary>
                /// <para>The description of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance health inspection results</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// </summary>
                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public List<string> Extensions { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The name of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inspection report</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of content parts.</para>
                /// </summary>
                [NameInMap("Parts")]
                [Validation(Required=false)]
                public List<SendNapalStreamMessageResponseBodyTaskArtifactsParts> Parts { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskArtifactsParts : TeaModel {
                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reserved.bin</para>
                    /// </summary>
                    [NameInMap("Filename")]
                    [Validation(Required=false)]
                    public string Filename { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/octet-stream</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmVzZXJ2ZWQ=</para>
                    /// </summary>
                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    /// <summary>
                    /// <para>The report text fragment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Diagnostic results</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The session context ID. Used to maintain context continuity in multi-turn conversations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context-07b0**bcc2</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>The list of historical messages.</para>
            /// </summary>
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<SendNapalStreamMessageResponseBodyTaskHistory> History { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskHistory : TeaModel {
                /// <summary>
                /// <para>The session context ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>context-07b0**bcc2</para>
                /// </summary>
                [NameInMap("ContextId")]
                [Validation(Required=false)]
                public string ContextId { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// </summary>
                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public List<string> Extensions { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>message-fd6e**9949</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The list of message content parts.</para>
                /// </summary>
                [NameInMap("Parts")]
                [Validation(Required=false)]
                public List<SendNapalStreamMessageResponseBodyTaskHistoryParts> Parts { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskHistoryParts : TeaModel {
                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reserved.bin</para>
                    /// </summary>
                    [NameInMap("Filename")]
                    [Validation(Required=false)]
                    public string Filename { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/octet-stream</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmVzZXJ2ZWQ=</para>
                    /// </summary>
                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    /// <summary>
                    /// <para>The text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Diagnose this instance ngw-xxx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// </summary>
                [NameInMap("ReferenceTaskIds")]
                [Validation(Required=false)]
                public List<string> ReferenceTaskIds { get; set; }

                /// <summary>
                /// <para>The message role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-38cZ**MAVKu</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-38cZ**MAVKu</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The extended metadata, used to pass additional context information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;usage&quot;:&quot;{totalTokens=327672}&quot;}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The task status object.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public SendNapalStreamMessageResponseBodyTaskStatus Status { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskStatus : TeaModel {
                /// <summary>
                /// <para>The message object defined by the A2A protocol. It contains the sender role, one or more content parts, and optional session and task context. When returned as a top-level field, it indicates a direct reply from the agent and is mutually exclusive with Task, TaskStatusUpdate, and TaskArtifactUpdate. The stream closes immediately after this message is returned. When returned as Status.Message, it represents a descriptive message associated with the task status. This API does not currently return a top-level Message. This field is reserved for protocol compatibility only.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public SendNapalStreamMessageResponseBodyTaskStatusMessage Message { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskStatusMessage : TeaModel {
                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>message-fd6e**9949</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    /// <summary>
                    /// <para>The list of message content parts.</para>
                    /// </summary>
                    [NameInMap("Parts")]
                    [Validation(Required=false)]
                    public List<SendNapalStreamMessageResponseBodyTaskStatusMessageParts> Parts { get; set; }
                    public class SendNapalStreamMessageResponseBodyTaskStatusMessageParts : TeaModel {
                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public object Data { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>reserved.bin</para>
                        /// </summary>
                        [NameInMap("Filename")]
                        [Validation(Required=false)]
                        public string Filename { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/octet-stream</para>
                        /// </summary>
                        [NameInMap("MediaType")]
                        [Validation(Required=false)]
                        public string MediaType { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cmVzZXJ2ZWQ=</para>
                        /// </summary>
                        [NameInMap("Raw")]
                        [Validation(Required=false)]
                        public string Raw { get; set; }

                        /// <summary>
                        /// <para>The text content. The natural language instruction entered by the user, such as a diagnostic request or question consultation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The current instance is running normally</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The message role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                /// <summary>
                /// <para>The task state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TASK_STATE_SUBMITTED: The task has been submitted.</description></item>
                /// <item><description>TASK_STATE_WORKING: The task is being executed.</description></item>
                /// <item><description>TASK_STATE_COMPLETED: The task has been completed.</description></item>
                /// <item><description>TASK_STATE_FAILED: The task has failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TASK_STATE_SUBMITTED</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The status timestamp in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-07T06:08:10Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The task artifact update object.</para>
        /// </summary>
        [NameInMap("TaskArtifactUpdate")]
        [Validation(Required=false)]
        public SendNapalStreamMessageResponseBodyTaskArtifactUpdate TaskArtifactUpdate { get; set; }
        public class SendNapalStreamMessageResponseBodyTaskArtifactUpdate : TeaModel {
            /// <summary>
            /// <para>Indicates whether the content is appended. A value of <c>true</c> indicates that the current Text is appended to the end of the existing report content. A value of <c>false</c> indicates that the existing content is overwritten.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Append")]
            [Validation(Required=false)]
            public bool? Append { get; set; }

            /// <summary>
            /// <para>The artifact object.</para>
            /// </summary>
            [NameInMap("Artifact")]
            [Validation(Required=false)]
            public SendNapalStreamMessageResponseBodyTaskArtifactUpdateArtifact Artifact { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskArtifactUpdateArtifact : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>output</para>
                /// </summary>
                [NameInMap("ArtifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                /// <summary>
                /// <para>The description of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Detailed inspection report</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// </summary>
                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public List<string> Extensions { get; set; }

                /// <summary>
                /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The name of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inspection report</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of content parts.</para>
                /// </summary>
                [NameInMap("Parts")]
                [Validation(Required=false)]
                public List<SendNapalStreamMessageResponseBodyTaskArtifactUpdateArtifactParts> Parts { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskArtifactUpdateArtifactParts : TeaModel {
                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reserved.bin</para>
                    /// </summary>
                    [NameInMap("Filename")]
                    [Validation(Required=false)]
                    public string Filename { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/octet-stream</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmVzZXJ2ZWQ=</para>
                    /// </summary>
                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    /// <summary>
                    /// <para>The report text fragment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Instance status is normal</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The session context ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context-07b0**bcc2</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the last chunk. A value of <c>true</c> indicates that the report content has been fully pushed and no more events will follow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LastChunk")]
            [Validation(Required=false)]
            public bool? LastChunk { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-38cZ**MAVKu</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The task status update object.</para>
        /// </summary>
        [NameInMap("TaskStatusUpdate")]
        [Validation(Required=false)]
        public SendNapalStreamMessageResponseBodyTaskStatusUpdate TaskStatusUpdate { get; set; }
        public class SendNapalStreamMessageResponseBodyTaskStatusUpdate : TeaModel {
            /// <summary>
            /// <para>The session context ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context-07b0**bcc2</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a final event. A value of true indicates that the task has ended (completed or failed) and no more events will be pushed after this.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Final")]
            [Validation(Required=false)]
            public bool? Final { get; set; }

            /// <summary>
            /// <para>The metadata object that contains step execution information.</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public SendNapalStreamMessageResponseBodyTaskStatusUpdateMetadata Metadata { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskStatusUpdateMetadata : TeaModel {
                /// <summary>
                /// <para>The step execution information.</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public SendNapalStreamMessageResponseBodyTaskStatusUpdateMetadataStep Step { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskStatusUpdateMetadataStep : TeaModel {
                    /// <summary>
                    /// <para>The execution duration of the step. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>203</para>
                    /// </summary>
                    [NameInMap("CostTime")]
                    [Validation(Required=false)]
                    public long? CostTime { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30688</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the step encountered an error during execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsError")]
                    [Validation(Required=false)]
                    public bool? IsError { get; set; }

                    /// <summary>
                    /// <para>The step name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>load_skill</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The input parameters of the step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;skill_id&quot;:&quot;239&quot;}</para>
                    /// </summary>
                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public object Params { get; set; }

                    /// <summary>
                    /// <para>The execution result of the step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public object Result { get; set; }

                    /// <summary>
                    /// <para>The number of retries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RetryCount")]
                    [Validation(Required=false)]
                    public long? RetryCount { get; set; }

                    /// <summary>
                    /// <para>The content displayed on the frontend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>load_skill</para>
                    /// </summary>
                    [NameInMap("UiContent")]
                    [Validation(Required=false)]
                    public string UiContent { get; set; }

                }

            }

            /// <summary>
            /// <para>The task status object.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public SendNapalStreamMessageResponseBodyTaskStatusUpdateStatus Status { get; set; }
            public class SendNapalStreamMessageResponseBodyTaskStatusUpdateStatus : TeaModel {
                /// <summary>
                /// <para>The message body object.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public SendNapalStreamMessageResponseBodyTaskStatusUpdateStatusMessage Message { get; set; }
                public class SendNapalStreamMessageResponseBodyTaskStatusUpdateStatusMessage : TeaModel {
                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>message-fd6e**9949</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    /// <summary>
                    /// <para>The list of message content parts.</para>
                    /// </summary>
                    [NameInMap("Parts")]
                    [Validation(Required=false)]
                    public List<SendNapalStreamMessageResponseBodyTaskStatusUpdateStatusMessageParts> Parts { get; set; }
                    public class SendNapalStreamMessageResponseBodyTaskStatusUpdateStatusMessageParts : TeaModel {
                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public object Data { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>reserved.bin</para>
                        /// </summary>
                        [NameInMap("Filename")]
                        [Validation(Required=false)]
                        public string Filename { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/octet-stream</para>
                        /// </summary>
                        [NameInMap("MediaType")]
                        [Validation(Required=false)]
                        public string MediaType { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cmVzZXJ2ZWQ=</para>
                        /// </summary>
                        [NameInMap("Raw")]
                        [Validation(Required=false)]
                        public string Raw { get; set; }

                        /// <summary>
                        /// <para>The text content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Query traffic</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>Reserved field. This parameter is not returned by the current operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/reserved.bin">https://example.com/reserved.bin</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The message role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TASK_STATE_WORKING: The task is running.</description></item>
                /// <item><description>TASK_STATE_COMPLETED: The task is completed.</description></item>
                /// <item><description>TASK_STATE_FAILED: The task has failed.</description></item>
                /// <item><description>TASK_STATE_CANCELED: The task is canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TASK_STATE_WORKING</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The status timestamp in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-07T06:08:30Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-38cZ**MAVKu</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
