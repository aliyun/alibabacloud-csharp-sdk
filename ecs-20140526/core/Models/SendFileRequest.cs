// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// The content of the remote file. The content must not exceed 32 KB in size after it is encoded in Base64.
        /// 
        /// *   If `ContentType` is set to `PlainText`, the Content value is in plaintext.
        /// *   If `ContentType` is set to `Base64`, the Content value is Base64-encoded.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The content type of the file. Valid values:
        /// 
        /// *   PlainText: The file content is not encoded.
        /// *   Base64: The file content is Base64-encoded.
        /// 
        /// Default value: PlainText.
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The description of the file. The description supports all character sets and can be up to 512 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The user group of the file. This parameter takes effect only for Linux instances. Default value: root. The user group name can be up to 64 characters in length.
        /// 
        /// >  If you want to use a non-root user group, make sure that the user group exists in the instances.
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// The permissions on the file. This parameter takes effect only for Linux instances. You can configure this parameter in the same way as you configure the chmod command.
        /// 
        /// Default value: 0644, which indicates that the owner of the file has the read and write permissions on the file and that the user group of the file and other users have the read-only permissions on the file.
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// The owner of the file. This parameter takes effect only for Linux instances. Default value: root. The value can be up to 64 characters in length.
        /// 
        /// >  If you want to use a non-root user, make sure that the user exists in the instances.
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// The ID of instance N to which to send the file. Up to 50 instance IDs can be specified in each request. Valid values of N: 1 to 50.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The name of the file. The name supports all character sets and can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether to overwrite a file in the destination directory if the file has the same name as the sent file.
        /// 
        /// *   true: overwrites the file.
        /// *   false: does not overwrite the file.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance to which to send the file. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. When you specify this parameter, take note of the following items:
        /// 
        /// *   The ECS instance specified by the InstanceId parameter must belong to this resource group.
        /// *   If you specify this parameter, you can call the [DescribeSendFileResults](~~184117~~) operation to query file sending results in the specified resource group.
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
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<SendFileRequestTag> Tag { get; set; }
        public class SendFileRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the file sending task. Valid values of N: 1 to 20. The tag key cannot be an empty string.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call the [ListTagResources](~~110425~~) operation.
            /// 
            /// The tag key can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the file sending task. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The destination directory on the instance to which to send the file. If the specified directory does not exist, the system creates the directory on the instance. The value supports all character sets and cannot exceed 255 characters in length.
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// The timeout period for the file sending task. Unit: seconds.
        /// 
        /// *   A timeout error occurs when a file cannot be sent because the process slows down or because a specific module or Cloud Assistant Agent does not exist.
        /// *   If the specified timeout period is less than 10 seconds, the system sets the timeout period to 10 seconds to ensure that the file can be sent to the instances.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
