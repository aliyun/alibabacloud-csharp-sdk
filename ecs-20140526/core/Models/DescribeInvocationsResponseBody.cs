// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                [NameInMap("CommandType")]
                [Validation(Required=false)]
                public string CommandType { get; set; }

                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

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

                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

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

                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public bool? Timed { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                [NameInMap("Launcher")]
                [Validation(Required=false)]
                public string Launcher { get; set; }

                [NameInMap("OssOutputDelivery")]
                [Validation(Required=false)]
                public string OssOutputDelivery { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationTagsTag : TeaModel {
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

                [NameInMap("Timed")]
                [Validation(Required=false)]
                public bool? Timed { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// <para>The overall execution status of the command task. The value of this parameter depends on the execution states of the command task on all involved instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: Before you stop the scheduled execution of the command, the overall execution state is always Running.</description></item>
        /// <item><description>One-time task: If the command is being run on instances, the overall execution state is Running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Finished:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The overall execution state can never be Finished.</description></item>
        /// <item><description>One-time task: The execution is complete on all instances, or the execution is stopped on some instances and is complete on the other instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Success: If the execution state on at least one instance is Success and the execution state on the other instances is Stopped or Success, the overall execution state is Success.</para>
        /// <list type="bullet">
        /// <item><description>One-time task: The execution is complete, and the exit code is 0.</description></item>
        /// <item><description>Scheduled task: The last execution is complete, the exit code is 0, and the specified period ends.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Failed:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The overall execution state can never be Failed.</description></item>
        /// <item><description>One-time task: The execution failed on all instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Stopped: The task is stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The task is being stopped.</para>
        /// </description></item>
        /// <item><description><para>PartialFailed: The task fails on some instances. If you specify both this parameter and <c>InstanceId</c>, this parameter does not take effect.</para>
        /// </description></item>
        /// <item><description><para>Pending: The command is being verified or sent. If the execution state on at least one instance is Pending, the overall execution state is Pending.</para>
        /// </description></item>
        /// <item><description><para>Scheduled: The command that is set to run on a schedule is sent and waiting to be run. If the execution state on at least one instance is Scheduled, the overall execution state is Scheduled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: batch command, applicable to Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command, applicable to Windows instances.</description></item>
        /// <item><description>RunShellScript: shell command, applicable to Linux instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The command ID. You can call the <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> operation to query all available command IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The command name. If you specify both this parameter and <c>InstanceId</c>, this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the command is to be automatically run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The command is run by calling the <c>RunCommand</c> or <c>InvokeCommand</c> operation with <c>RepeatMode</c> set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c>.</para>
        /// </description></item>
        /// <item><description><para>false: The command meets one of the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The command is run by calling the <c>RunCommand</c> or <c>InvokeCommand</c> operation with <c>RepeatMode</c> set to <c>Once</c>.</description></item>
        /// <item><description>The command task is canceled, stopped, or completed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
