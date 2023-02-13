// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        /// <summary>
        /// Details about the file sending records.
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
                /// The content type of the file. Valid values:
                /// 
                /// *   PlainText: The file content is not encoded.
                /// *   Base64: The file content is Base64-encoded.
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
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The user group of the file.
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
                /// The overall sending state of the file. The overall sending state of the file depends on its sending state on all the destination instances. Valid values:
                /// 
                /// *   Pending: The file is being verified or sent. If the sending state of the file on at least one instance is Pending, the overall sending state of the file is Pending.
                /// 
                /// *   Running: The file creation task is running on the instances. If the sending state of the file on at least one instance is Running, the overall sending state of the file is Running.
                /// 
                /// *   Success: If the sending state of the file on all the instances is Success, the overall sending state of the file is Success.
                /// 
                /// *   Failed: If the sending state of the file on all the instances is Failed, the overall sending state of the file is Failed. If the sending state of the file on one or more instances is one of the following values, the overall sending state of the file is Failed:
                /// 
                ///     *   Invalid: The file is invalid.
                ///     *   Aborted: The file failed to be sent.
                ///     *   Failed: The file failed to be created.
                ///     *   Timeout: The file sending task timed out.
                ///     *   Error: An error occurred while the file is being sent.
                /// 
                /// *   PartialFailed: The file was sent to some of the specified instances and failed to be sent to the others. The overall sending state of the file is PartialFailed only when its sending state is Success on some instances and is Failed on the others.
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
                /// Details about the destination instances.
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
                        /// The time when the file sending task was created.
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// The error code returned when the file failed to be sent to the instance. Valid values:
                        /// 
                        /// *   Null: The file is sent to the instance.
                        /// *   InstanceNotExists: The instance does not exist or was released.
                        /// *   InstanceReleased: The instance was released while the file was being sent.
                        /// *   InstanceNotRunning: The instance was not running when the file sending task was being created.
                        /// *   AccountNotExists: The specified account does not exist.
                        /// *   ClientNotRunning: The Cloud Assistant client is not running.
                        /// *   ClientNotResponse: The Cloud Assistant client is not responding.
                        /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
                        /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
                        /// *   DeliveryTimeout: The file sending task timed out.
                        /// *   FileCreateFail: The file failed to be created.
                        /// *   FileAlreadyExists: A file with the same name already exists in the specified directory.
                        /// *   FileContentInvalid: The file content is invalid.
                        /// *   FileNameInvalid: The file name is invalid.
                        /// *   FilePathInvalid: The specified directory is invalid.
                        /// *   FileAuthorityInvalid: The specified permissions on the file are invalid.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// The error message returned when the file failed to be sent or the file sending task failed to be executed. Valid values:
                        /// 
                        /// *   Null: The file is sent to the instance.
                        /// *   the specified instance does not exists: The specified instance does not exist or was released.
                        /// *   the instance has released when create task: The specified instance was released when the file was being sent.
                        /// *   the instance is not running when create task: The specified instance was not running when the file sending task was being created.
                        /// *   the specified account does not exists: The specified account does not exist.
                        /// *   the aliyun service is not running on the instance: The Cloud Assistance client is not running.
                        /// *   the aliyun service in the instance does not response: The Cloud Assistant client is not responding.
                        /// *   the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.
                        /// *   the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.
                        /// *   the command delivery has been timeout: The file sending task timed out.
                        /// *   Unexpected error during creating: The file failed to be created.
                        /// *   File already exists: A file with the same name already exists in the specified directory.
                        /// *   File content error: The file content is invalid.
                        /// *   File name is invalid: The file name is invalid.
                        /// *   File path is invalid: The specified directory is invalid.
                        /// *   Owner not exists: The owner of the file does not exist.
                        /// *   Group not exists: The user group does not exist.
                        /// *   Mode is invalid: The specified permissions on the file are invalid.
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// The time when the file sending task finished being executed.
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
                        /// The state of the file sending task.
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
                        /// The time when the execution status was last updated.
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

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

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
                /// The number of instances to which the file was sent.
                /// </summary>
                [NameInMap("VmCount")]
                [Validation(Required=false)]
                public int? VmCount { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of file sending tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
