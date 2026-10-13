// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file sending records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeSendFileResultsResponseBodyInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The command execution ID.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeSendFileResultsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The output information after command execution.</para>
                /// <para>If ContentEncoding is set to PlainText, the original output information is returned.
                /// If ContentEncoding is set to Base64, the Base64-encoded output information is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Base64</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The file content type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PlainText: Plain text.</description></item>
                /// <item><description>Base64: Base64 encoding.</description></item>
                /// </list>
                /// <para>Default value: PlainText.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PlainText</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The time when the sending task was created. The time is in ISO 8601 format and includes the time zone offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-10T10:53:46.156+08:00</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The command description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description information</para>
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
                /// <para>The permissions of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                /// <summary>
                /// <para>The user of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                /// <summary>
                /// <para>The overall sending status of the file. The overall status depends on the combined execution status of all instances in this sending operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is validating or sending the file. If the file sending status of at least one instance is Pending, the overall status is Pending.</description></item>
                /// <item><description>Running: The file is being sent on the instance. If the file sending status of at least one instance is Running, the overall status is Running.</description></item>
                /// <item><description>Success: If the file sending status on all instances is Success, the overall status is Success.</description></item>
                /// <item><description>Failed: If the file sending status on all instances is Failed, the overall status is Failed. The return value is Failed when one or more of the following statuses occur on an instance:<list type="bullet">
                /// <item><description>The specified file parameters are invalid and validation failed (Invalid).</description></item>
                /// <item><description>Failed to send the file to the instance (Aborted).</description></item>
                /// <item><description>Failed to create the file on the instance (Failed).</description></item>
                /// <item><description>File sending timed out (Timeout).</description></item>
                /// <item><description>An exception occurred during file sending and the operation cannot continue (Error).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>PartialFailed: File sending succeeded on some instances but failed on others. If the file sending status on all instances is either Success or Failed, the overall status is PartialFailed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The file sending records.</para>
                /// </summary>
                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    /// <summary>
                    /// <para>The file sending record of a node.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The time when the file sending task was created. The time is in ISO 8601 format. Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The error code for the file sending failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: File sending was normal.</description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>NodeReleased: The instance was released during file sending.</description></item>
                        /// <item><description>NodeNotRunning: The instance was not running when the file sending task was created.</description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                        /// <item><description>ClientNotRunning: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>ClientNotResponse: Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>ClientIsUpgrading: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: File sending timed out.</description></item>
                        /// <item><description>FileCreateFail: File creation failed.</description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name already exists in the same path.</description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid.</description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid.</description></item>
                        /// <item><description>FilePathInvalid: The file path is invalid.</description></item>
                        /// <item><description>FileAuthorityInvalid: The file permissions are invalid.</description></item>
                        /// <item><description>UserGroupNotExists: The user group specified during file sending does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AccountNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The details of the reason why the command failed to be sent or executed. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The command was executed normally.</description></item>
                        /// <item><description>the specified instance does not exists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>the node has released when create task: The instance was released during command execution.</description></item>
                        /// <item><description>the node is not running when create task: The instance was not running when the command was executed.</description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                        /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                        /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                        /// <item><description>the cron job expression is invalid: The specified execution time expression is invalid.</description></item>
                        /// <item><description>the aliyun service is not running on the instance: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>the aliyun service in the instance does not response: Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>the aliyun service in the node need upgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>the command delivery has been timeout: Sending the command timed out.</description></item>
                        /// <item><description>the command execution has been timeout: Command execution timed out.</description></item>
                        /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
                        /// <item><description>the command execution has been interrupted: Command execution was interrupted.</description></item>
                        /// <item><description>the command execution exit code is not zero: Command execution ended with a non-zero exit code.</description></item>
                        /// <item><description>the specified instance has been released: The instance was released during file sending.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified instance does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>The end time, in the format: &quot;2020-05-22T17:04:18&quot;.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-04-10T10:53:46.156+08:00</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The file sending status on a single instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The system is validating or sending the file.</description></item>
                        /// <item><description>Invalid: The specified file parameters are invalid and validation failed.</description></item>
                        /// <item><description>Running: The file is being sent on the instance.</description></item>
                        /// <item><description>Aborted: Failed to send the file to the instance.</description></item>
                        /// <item><description>Success: File sending completed.</description></item>
                        /// <item><description>Failed: Failed to create the file on the instance.</description></item>
                        /// <item><description>Error: An exception occurred during file sending and the operation cannot continue.</description></item>
                        /// <item><description>Timeout: File sending timed out.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Success</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <para>The node ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e01-cn-9lb3c15m81j</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The start time. The time is in ISO 8601 format. Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The update time. The time is in ISO 8601 format. Z in the example indicates UTC.</para>
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
                /// <para>The file sending name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>Specifies whether to overwrite the file if a file with the same name already exists in the target directory. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Overwrite the file.</description></item>
                /// <item><description>false: Do not overwrite the file.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public bool? Overwrite { get; set; }

                /// <summary>
                /// <para>The target path.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
