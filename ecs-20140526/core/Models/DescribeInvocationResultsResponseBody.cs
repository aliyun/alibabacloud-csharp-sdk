// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution status of the command task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: Before you stop the scheduled execution of the command, the execution state is always Running.</description></item>
        /// <item><description>One-time task: If the command is being run on instances, the execution state is Running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Finished:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be Finished.</description></item>
        /// <item><description>One-time task: The execution is complete on all instances, or the execution is stopped on some instances and is complete on the other instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Success:</para>
        /// <list type="bullet">
        /// <item><description>One-time task: The execution is complete, and the exit code is 0.</description></item>
        /// <item><description>Scheduled task: The last execution is complete, the exit code is 0, and the specified period ends.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Failed:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be Failed.</description></item>
        /// <item><description>One-time task: The execution fails on all instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PartialFailed:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be PartialFailed.</description></item>
        /// <item><description>One-time task: The execution fails on some instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Stopped: The task is stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The task is being stopped.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Invocation")]
        [Validation(Required=false)]
        public DescribeInvocationResultsResponseBodyInvocation Invocation { get; set; }
        public class DescribeInvocationResultsResponseBodyInvocation : TeaModel {
            [NameInMap("InvocationResults")]
            [Validation(Required=false)]
            public DescribeInvocationResultsResponseBodyInvocationInvocationResults InvocationResults { get; set; }
            public class DescribeInvocationResultsResponseBodyInvocationInvocationResults : TeaModel {
                [NameInMap("InvocationResult")]
                [Validation(Required=false)]
                public List<DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResult> InvocationResult { get; set; }
                public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResult : TeaModel {
                    [NameInMap("CommandId")]
                    [Validation(Required=false)]
                    public string CommandId { get; set; }

                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorInfo")]
                    [Validation(Required=false)]
                    public string ErrorInfo { get; set; }

                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InvocationStatus")]
                    [Validation(Required=false)]
                    public string InvocationStatus { get; set; }

                    [NameInMap("InvokeId")]
                    [Validation(Required=false)]
                    public string InvokeId { get; set; }

                    [NameInMap("InvokeRecordStatus")]
                    [Validation(Required=false)]
                    public string InvokeRecordStatus { get; set; }

                    [NameInMap("Launcher")]
                    [Validation(Required=false)]
                    public string Launcher { get; set; }

                    [NameInMap("OssOutputDelivery")]
                    [Validation(Required=false)]
                    public string OssOutputDelivery { get; set; }

                    [NameInMap("OssOutputErrorCode")]
                    [Validation(Required=false)]
                    public string OssOutputErrorCode { get; set; }

                    [NameInMap("OssOutputErrorInfo")]
                    [Validation(Required=false)]
                    public string OssOutputErrorInfo { get; set; }

                    [NameInMap("OssOutputStatus")]
                    [Validation(Required=false)]
                    public string OssOutputStatus { get; set; }

                    [NameInMap("OssOutputUri")]
                    [Validation(Required=false)]
                    public string OssOutputUri { get; set; }

                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    [NameInMap("Repeats")]
                    [Validation(Required=false)]
                    public int? Repeats { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("StopTime")]
                    [Validation(Required=false)]
                    public string StopTime { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags Tags { get; set; }
                    public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags : TeaModel {
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public List<DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag> Tag { get; set; }
                        public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag : TeaModel {
                            [NameInMap("TagKey")]
                            [Validation(Required=false)]
                            public string TagKey { get; set; }

                            [NameInMap("TagValue")]
                            [Validation(Required=false)]
                            public string TagValue { get; set; }

                        }

                    }

                    [NameInMap("TerminationMode")]
                    [Validation(Required=false)]
                    public string TerminationMode { get; set; }

                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// <remarks>
            /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAdDWBF2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> values in the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PlainText: returns the original command content and command output.</description></item>
            /// <item><description>Base64: returns the Base64-encoded command content and command output.</description></item>
            /// </list>
            /// <para>Default value: Base64.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the results of historical scheduled executions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: returns the results of historical scheduled executions. If you set this parameter to true, you must set InvokeId to the ID of a task that is run on a schedule (RepeatMode set to Period) or on each system startup (RepeatMode set to EveryReboot).</description></item>
            /// <item><description>false: does not return the results of historical scheduled executions.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
