// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>Record of file distribution.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeSendFileResultsResponseBodyInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>Command execution ID.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeSendFileResultsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>Output information after command execution.</para>
                /// <para>If ContentEncoding is specified as PlainText, the original output information is returned.
                /// If ContentEncoding is specified as Base64, the Base64 encoded output information is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Base64</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>File content type.</para>
                /// <para>PlainText: Plain text.
                /// Base64: Base64 encoding.
                /// The default value is PlainText.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PlainText</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>Creation time of the distribution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-10T10:53:46.156+08:00</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Command description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述信息。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The user group of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FileGroup")]
                [Validation(Required=false)]
                public string FileGroup { get; set; }

                /// <summary>
                /// <para>File permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                /// <summary>
                /// <para>The owner of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                /// <summary>
                /// <para>Overall status of the file distribution. The overall status depends on the common execution status of all instances involved in this distribution, possible values are:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is verifying or distributing the file. If at least one instance has a file distribution status of Pending, the overall execution status will be Pending.</description></item>
                /// <item><description>Running: The file is being distributed on the instance. If at least one instance has a file distribution status of Running, the overall execution status will be Running.</description></item>
                /// <item><description>Success: All instances have a file distribution status of Success, then the overall execution status will be Success.</description></item>
                /// <item><description>Failed: All instances have a file distribution status of Failed, then the overall execution status will be Failed. If any of the following conditions occur for the file distribution status on an instance, the return value will be Failed:<list type="bullet">
                /// <item><description>The specified file parameters are incorrect, verification failed (Invalid).</description></item>
                /// <item><description>Failed to distribute the file to the instance (Aborted).</description></item>
                /// <item><description>The file creation failed within the instance (Failed).</description></item>
                /// <item><description>The file distribution timed out (Timeout).</description></item>
                /// <item><description>An exception occurred during file distribution and could not continue (Error).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>PartialFailed: Some instances successfully received the file while others failed. If the file distribution status of all instances is either Success or Failed, the overall execution status will be PartialFailed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>Record of file distribution.</para>
                /// </summary>
                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    /// <summary>
                    /// <para>Record of file distribution for the node.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The creation time of the file distribution task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The failure reason code for file distribution. Possible values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The file was distributed normally. </description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released. </description></item>
                        /// <item><description>NodeReleased: The instance was released during the file distribution process. </description></item>
                        /// <item><description>NodeNotRunning: The instance was not running when the file distribution task was created. </description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist. </description></item>
                        /// <item><description>ClientNotRunning: The Cloud Assistant Agent is not running. </description></item>
                        /// <item><description>ClientNotResponse: The Cloud Assistant Agent is not responding. </description></item>
                        /// <item><description>ClientIsUpgrading: The Cloud Assistant Agent is currently being upgraded. </description></item>
                        /// <item><description>ClientNeedUpgrade: The Cloud Assistant Agent needs to be upgraded. </description></item>
                        /// <item><description>DeliveryTimeout: File delivery timed out. </description></item>
                        /// <item><description>FileCreateFail: Failed to create the file. </description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name already exists at the specified path. </description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid. </description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid. </description></item>
                        /// <item><description>FilePathInvalid: The file path is invalid. </description></item>
                        /// <item><description>FileAuthorityInvalid: The file permissions are invalid. </description></item>
                        /// <item><description>UserGroupNotExists: The user group specified for file delivery does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AccountNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>Details of the reason for command delivery failure or execution failure, possible values: </para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The command executed normally. </description></item>
                        /// <item><description>the specified instance does not exist: The specified instance does not exist or has been released. </description></item>
                        /// <item><description>the node has been released when creating task: The instance was released during the command execution. </description></item>
                        /// <item><description>the node is not running when creating task: The instance was not in a running state when the command was executed. </description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance. </description></item>
                        /// <item><description>the specified account does not exist: The specified account does not exist. </description></item>
                        /// <item><description>the specified directory does not exist: The specified directory does not exist. </description></item>
                        /// <item><description>the cron job expression is invalid: The specified execution time expression is invalid. </description></item>
                        /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant Agent is not running. </description></item>
                        /// <item><description>the aliyun service in the instance does not respond: The Cloud Assistant Agent is not responding. </description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: The Cloud Assistant Agent is currently being upgraded. </description></item>
                        /// <item><description>the aliyun service in the node needs upgrade: The Cloud Assistant Agent needs an upgrade. </description></item>
                        /// <item><description>the command delivery has timed out: Command delivery has timed out. </description></item>
                        /// <item><description>the command execution has timed out: Command execution has timed out. </description></item>
                        /// <item><description>the command execution got an exception: An exception occurred during command execution. </description></item>
                        /// <item><description>the command execution has been interrupted: The command execution was interrupted. </description></item>
                        /// <item><description>the command execution exit code is not zero: The command execution completed with a non-zero exit code. </description></item>
                        /// <item><description>the specified instance has been released: The instance was released during file delivery.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified instance does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>Completion time, format: &quot;2020-05-22T17:04:18&quot;.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-04-10T10:53:46.156+08:00</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>Status of the task on a single instance. Possible values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The system is validating or distributing the file.</description></item>
                        /// <item><description>Invalid: The specified file parameters are incorrect, and validation failed.</description></item>
                        /// <item><description>Running: The file is being distributed to the instance.</description></item>
                        /// <item><description>Aborted: Failed to distribute the file to the instance.</description></item>
                        /// <item><description>Success: The file distribution is complete.</description></item>
                        /// <item><description>Failed: The file creation failed within the instance.</description></item>
                        /// <item><description>Error: An exception occurred during file distribution and could not continue.</description></item>
                        /// <item><description>Timeout: The file distribution timed out.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Success</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <para>Node ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e01-cn-9lb3c15m81j</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>Start Time</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>Update Time</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>Name of the file distribution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Number of nodes</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>Whether to overwrite the file if a file with the same name already exists in the target directory.</para>
                /// <list type="bullet">
                /// <item><description>true: Overwrite.</description></item>
                /// <item><description>false: Do not overwrite.</description></item>
                /// </list>
                /// <para>The default value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public bool? Overwrite { get; set; }

                /// <summary>
                /// <para>Target path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/home/user</para>
                /// </summary>
                [NameInMap("TargetDir")]
                [Validation(Required=false)]
                public string TargetDir { get; set; }

            }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
