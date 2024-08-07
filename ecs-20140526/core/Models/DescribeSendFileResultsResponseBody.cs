// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        /// <summary>
        /// The file sending records.
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
                /// The content of the file.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The type of the file content. Valid values:
                /// 
                /// *   PlainText: The file content is not encoded.
                /// *   Base64: The file content is encoded in Base64.
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// The time when the file sending task was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the file.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The group of the file.
                /// </summary>
                [NameInMap("FileGroup")]
                [Validation(Required=false)]
                public string FileGroup { get; set; }

                /// <summary>
                /// The permissions on the file.
                /// </summary>
                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                /// <summary>
                /// The owner of the file.
                /// </summary>
                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                /// <summary>
                /// The overall sending status of the file. The overall sending status of the file varies based on the sending status of the file on all destination instances. Valid values:
                /// 
                /// *   Pending: The file is being verified or sent. If the sending state of the file on at least one instance is Pending, the overall sending state of the file is Pending.
                /// 
                /// *   Running: The file is being sent to the instances. If the sending state of the file on at least one instance is Running, the overall sending state of the file is Running.
                /// 
                /// *   Success: If the sending state of the file on all instances is Success, the overall sending state of the file is Success.
                /// 
                /// *   If the sending state of the file on all instances is Failed, the overall sending state of the file is Failed. If the sending state of the file on one or more instances is one of the following values, the overall sending state of the file is Failed:
                /// 
                ///     *   Invalid: The file is invalid.
                ///     *   Aborted: The file failed to be sent to the instances.
                ///     *   Failed: The file failed to be created on the instances.
                ///     *   Timeout: The file sending task timed out.
                ///     *   Error: An error occurred and interrupted the file sending task.
                /// 
                /// *   PartialFailed: The file sending task was completed on some instances but failed on other instances. If the sending state of the file is Success on some instances and is Failed on other instances, the overall sending state of the file is PartialFailed.
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// The ID of the file sending task.
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// The destination instances.
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
                        /// The creation time of the file sending task.
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// The error code returned when the file failed to be sent to the instance. Valid values:
                        /// 
                        /// *   Null: The file is sent to the instance.
                        /// *   InstanceNotExists: The instance does not exist or has been released.
                        /// *   InstanceReleased: The instance is released while the file is being sent.
                        /// *   InstanceNotRunning: The instance is not running when the file sending task is being created.
                        /// *   AccountNotExists: The specified account does not exist.
                        /// *   ClientNotRunning: Cloud Assistant Agent is not running.
                        /// *   ClientNotResponse: Cloud Assistant Agent does not respond.
                        /// *   ClientIsUpgrading: Cloud Assistant Agent is being upgraded.
                        /// *   ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.
                        /// *   DeliveryTimeout: The file sending task timed out.
                        /// *   FileCreateFail: The file failed to be created.
                        /// *   FileAlreadyExists: A file with the same name exists in the specified directory.
                        /// *   FileContentInvalid: The file content is invalid.
                        /// *   FileNameInvalid: The file name is invalid.
                        /// *   FilePathInvalid: The specified directory is invalid.
                        /// *   FileAuthorityInvalid: The specified permissions on the file are invalid.
                        /// *   UserGroupNotExists: The specified user group does not exist.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// The error message returned when the file failed to be sent or the file sending task failed to be executed. Valid values:
                        /// 
                        /// *   Null: The file is sent to the instance.
                        /// *   the specified instance does not exists
                        /// *   the specified instance has been released
                        /// *   the instance is not running when create task
                        /// *   the specified account does not exists
                        /// *   the aliyun service is not running on the instance
                        /// *   the aliyun service in the instance does not response
                        /// *   the aliyun service in the instance is upgrading now
                        /// *   the aliyun service in the instance need upgrade
                        /// *   the command delivery has been timeout
                        /// *   the file creation is failed due to unknown error
                        /// *   the authority of file is invalid
                        /// *   File content is empty
                        /// *   the content of file is invalid
                        /// *   File already exists
                        /// *   File name is invalid
                        /// *   File path is invalid
                        /// *   Owner not exists
                        /// *   Group not exists
                        /// *   Mode is invalid
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// The time when the file sending task was completed.
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// The ID of the instance.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The status of the file sending task. Valid values:
                        /// 
                        /// *   Pending: The file is being verified or sent.
                        /// *   Invalid: The file is invalid.
                        /// *   Running: The file is being sent to the instance.
                        /// *   Aborted: The file failed to be sent to the instance.
                        /// *   Success: The file is sent.
                        /// *   Failed: The file failed to be created on the instance.
                        /// *   Error: An error occurred and interrupted the file sending task.
                        /// *   Timeout: The file sending task timed out.
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// The time when the file sending task started to be executed on the instance.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The time when the task status was last updated.
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// The name of the file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether a file in the destination directory is overwritten if the file has the same name as the sent file.
                /// </summary>
                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public string Overwrite { get; set; }

                /// <summary>
                /// The tags of the file sending task.
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
                        /// The tag key of the file sending task.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the file sending task.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The destination directory.
                /// </summary>
                [NameInMap("TargetDir")]
                [Validation(Required=false)]
                public string TargetDir { get; set; }

                /// <summary>
                /// The number of the destination instances.
                /// </summary>
                [NameInMap("VmCount")]
                [Validation(Required=false)]
                public int? VmCount { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of file sending tasks queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
