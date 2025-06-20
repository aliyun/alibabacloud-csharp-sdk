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
                /// <para>The command output.</para>
                /// <para>If ContentEncoding is set to PlainText in the request, the original command output is returned. If ContentEncoding is set to Base64 in the request, the Base64-encoded command output is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Base64</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The content type of the file.</para>
                /// <para>PlainText: The file content is not encoded. Base64: The file content is encoded in Base64. Default value: PlainText.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PlainText</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The time when the file sending task was created.</para>
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
                /// <para>Description</para>
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
                /// <para>The permissions on the file.</para>
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
                /// <para>The overall sending status of the file. The overall sending status of the file varies based on the sending status of the file on all destination instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The file is being verified or sent. If the sending state of the file on at least one instance is Pending, the overall sending state of the file is Pending.</para>
                /// </description></item>
                /// <item><description><para>Running: The file is being sent to the instance. If the sending state of the file on at least one instance is Running, the overall sending state of the file is Running.</para>
                /// </description></item>
                /// <item><description><para>Success: If the sending state of the file on all instances is Success, the overall sending state of the file is Success.</para>
                /// </description></item>
                /// <item><description><para>Failed: If the sending state of the file on all instances is Failed, the overall sending state of the file is Failed. If the sending state of the file on one or more instances is one of the following values, the overall sending state of the file is Failed:</para>
                /// <list type="bullet">
                /// <item><description>Invalid: The file is invalid.</description></item>
                /// <item><description>Aborted: The file failed to be sent to the instances.</description></item>
                /// <item><description>Failed: The file failed to be created on the instances.</description></item>
                /// <item><description>Timeout: The file sending task timed out.</description></item>
                /// <item><description>Error: An error occurred and interrupted the file sending task.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>PartialFailed: The file sending task was completed on some instances but failed on other instances. If the sending state of the file is Success on some instances and is Failed on other instances, the overall sending state of the file is PartialFailed.</para>
                /// </description></item>
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
                    /// <para>The file sending records on a node.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The time when the file sending task was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The error code returned when the file failed to be sent to the instance. Valid values:</para>
                        /// <para>Null: The file is sent to the instance. NodeNotExists: The specified instance does not exist or has been released. NodeReleased: The instance was released while the file was being sent. NodeNotRunning: The instance was not running while the file sending task was being created. AccountNotExists: The specified account does not exist. ClientNotRunning: Cloud Assistant Agent is not running. ClientNotResponse: Cloud Assistant Agent did not respond. ClientIsUpgrading: Cloud Assistant Agent was being upgraded. ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded. DeliveryTimeout: The file sending task timed out. FileCreateFail: The file failed to be created. FileAlreadyExists: A file with the same name exists in the specified directory. FileContentInvalid: The file content is invalid. FileNameInvalid: The file name is invalid. FilePathInvalid: The specified directory is invalid. FileAuthorityInvalid: The specified permissions on the file are invalid. UserGroupNotExists: The specified user group does not exist.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AccountNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message returned if the command failed to be sent or run. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>null: The command is run as expected.</description></item>
                        /// <item><description>the specified instance does not exists: The specified instance does not exist or is released.</description></item>
                        /// <item><description>the node has released when create task: The instance is released when the command is being run.</description></item>
                        /// <item><description>the node is not running when create task: The instance is not in the Running state while the command is being run.</description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                        /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                        /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                        /// <item><description>the cron job expression is invalid: The cron expression that specifies the execution time is invalid.</description></item>
                        /// <item><description>the aliyun service is not running on the instance: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>the aliyun service in the instance does not response: Cloud Assistant Agent does not respond.</description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>the aliyun service in the node need upgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>the command delivery has been timeout: The request to send the command timed out.</description></item>
                        /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
                        /// <item><description>the command execution got an exception: An exception occurred when the command is being run.</description></item>
                        /// <item><description>the command execution has been interrupted: The command execution is interrupted.</description></item>
                        /// <item><description>the command execution exit code is not zero: The command execution completes, but the exit code is not 0.</description></item>
                        /// <item><description>the specified instance has been released: The instance is released while the file is being sent.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified instance does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>The time when the file sending task ends. The time is in the 2020-05-22T17:04:18 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-04-10T10:53:46.156+08:00</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The status of the file sending task on an instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The file is being verified or sent.</description></item>
                        /// <item><description>Invalid: The file is invalid.</description></item>
                        /// <item><description>Running: The file is being sent to the instance.</description></item>
                        /// <item><description>Aborted: The file failed to be sent to the instance.</description></item>
                        /// <item><description>Success: The file is sent.</description></item>
                        /// <item><description>Failed: The file failed to be created on the instance.</description></item>
                        /// <item><description>Error: An error occurred and interrupted the file sending task.</description></item>
                        /// <item><description>Timeout: The file sending task timed out.</description></item>
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
                        /// <para>The start time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The update time.</para>
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
                /// <para>The name of the file sending task.</para>
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
                /// <para>Indicates whether a file was overwritten in the destination directory if the file has the same name as the sent file.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
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
                /// <para>The destination directory.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
