// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsRequest : TeaModel {
        /// <summary>
        /// The page number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The information about the tag.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The tags to use for query.
        /// </summary>
        [NameInMap("IncludeHistory")]
        [Validation(Required=false)]
        public bool? IncludeHistory { get; set; }

        /// <summary>
        /// The encoding method of the `Output` response parameter. Valid values:
        /// 
        /// *   PlainText: returns the original command content and command output.
        /// *   Base64: returns the Base64-encoded command content and command output.
        /// 
        /// Default value: Base64.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to return the results of historical scheduled executions. Valid values:
        /// 
        /// *   true: returns the results of historical scheduled executions. When this parameter is set to true, the `InvokeId` parameter must be set to the ID of a scheduled execution.
        /// *   false: does not return the results of historical scheduled executions.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key of tag N of the command execution. Valid values of N: 1 to 20. The tag key cannot be an empty string.
        /// 
        /// If a single tag is specified to query resources, up to 1,000 resources with this tag can be returned. If multiple tags are specified to query resources, up to 1,000 resources with all these tags can be returned. To query more than 1,000 resources with specified tags, call the [ListTagResources](~~110425~~) operation.
        /// 
        /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The value of tag N of the command execution. Valid values of N: 1 to 20. The tag value can be an empty string.
        /// 
        /// It can be up to 128 characters in length and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the command.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The execution state of the command. Valid values:
        /// 
        /// *   Running
        /// *   Finished
        /// *   Failed
        /// *   Stopped
        /// 
        /// > To ensure compatibility, we recommend that you use the `InvocationStatus` parameter instead of the InvokeRecordStatus parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
