// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file sending records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeSendFileResultsResponseBodyInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeSendFileResultsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The content of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash  echo &quot;Current User is :&quot;  echo $(ps | grep &quot;$$&quot; | awk \&quot;{print $2}\&quot;)</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The type of the file content. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PlainText: The file content is not encoded.</description></item>
                /// <item><description>Base64: The file content is encoded in Base64.</description></item>
                /// </list>
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
                /// <para>2019-12-20T06:15:54Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test file.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The group of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileGroup")]
                [Validation(Required=false)]
                public string FileGroup { get; set; }

                /// <summary>
                /// <para>The permissions on the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>777</para>
                /// </summary>
                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                /// <summary>
                /// <para>The owner of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                /// <summary>
                /// <para>The overall sending status of the file. The overall sending status of the file varies based on the sending status of the file on all destination instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The file is being verified or sent. If the sending state of the file on at least one instance is Pending, the overall sending state of the file is Pending.</para>
                /// </description></item>
                /// <item><description><para>Running: The file is being sent to the instances. If the sending state of the file on at least one instance is Running, the overall sending state of the file is Running.</para>
                /// </description></item>
                /// <item><description><para>Success: If the sending state of the file on all instances is Success, the overall sending state of the file is Success.</para>
                /// </description></item>
                /// <item><description><para>If the sending state of the file on all instances is Failed, the overall sending state of the file is Failed. If the sending state of the file on one or more instances is one of the following values, the overall sending state of the file is Failed:</para>
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
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The ID of the file sending task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f-hz0jdfwd9f****</para>
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// <para>The destination instances.</para>
                /// </summary>
                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        /// <summary>
                        /// <para>The creation time of the file sending task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:54Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The error code returned when the file failed to be sent to the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Null: The file is sent to the instance.</description></item>
                        /// <item><description>InstanceNotExists: The instance does not exist or has been released.</description></item>
                        /// <item><description>InstanceReleased: The instance is released while the file is being sent.</description></item>
                        /// <item><description>InstanceNotRunning: The instance is not running when the file sending task is being created.</description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                        /// <item><description>ClientNotRunning: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>ClientNotResponse: Cloud Assistant Agent does not respond.</description></item>
                        /// <item><description>ClientIsUpgrading: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: The file sending task timed out.</description></item>
                        /// <item><description>FileCreateFail: The file failed to be created.</description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name exists in the specified directory.</description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid.</description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid.</description></item>
                        /// <item><description>FilePathInvalid: The specified directory is invalid.</description></item>
                        /// <item><description>FileAuthorityInvalid: The specified permissions on the file are invalid.</description></item>
                        /// <item><description>UserGroupNotExists: The specified user group does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InstanceNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message returned when the file failed to be sent or the file sending task failed to be executed. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Null: The file is sent to the instance.</description></item>
                        /// <item><description>the specified instance does not exists</description></item>
                        /// <item><description>the specified instance has been released</description></item>
                        /// <item><description>the instance is not running when create task</description></item>
                        /// <item><description>the specified account does not exists</description></item>
                        /// <item><description>the aliyun service is not running on the instance</description></item>
                        /// <item><description>the aliyun service in the instance does not response</description></item>
                        /// <item><description>the aliyun service in the instance is upgrading now</description></item>
                        /// <item><description>the aliyun service in the instance need upgrade</description></item>
                        /// <item><description>the command delivery has been timeout</description></item>
                        /// <item><description>the file creation is failed due to unknown error</description></item>
                        /// <item><description>the authority of file is invalid</description></item>
                        /// <item><description>File content is empty</description></item>
                        /// <item><description>the content of file is invalid</description></item>
                        /// <item><description>File already exists</description></item>
                        /// <item><description>File name is invalid</description></item>
                        /// <item><description>File path is invalid</description></item>
                        /// <item><description>Owner not exists</description></item>
                        /// <item><description>Group not exists</description></item>
                        /// <item><description>Mode is invalid</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the instance is not running when create task</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>The time when the file sending task was completed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:54Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-uf614fhehhz****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The status of the file sending task. Valid values:</para>
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
                        /// <para>The time when the file sending task started to be executed on the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:54Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when the task status was last updated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:54Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.txt</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether a file in the destination directory is overwritten if the file has the same name as the sent file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public string Overwrite { get; set; }

                /// <summary>
                /// <para>The tags of the file sending task.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the file sending task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>owner</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the file sending task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>zhangsan</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The destination directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/home/user</para>
                /// </summary>
                [NameInMap("TargetDir")]
                [Validation(Required=false)]
                public string TargetDir { get; set; }

                /// <summary>
                /// <para>The number of the destination instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VmCount")]
                [Validation(Required=false)]
                public int? VmCount { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of file sending tasks queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
