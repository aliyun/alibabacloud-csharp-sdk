// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// The content of the file. The content must not exceed 32 KB in size after it is encoded in Base64.
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
        /// *   PlainText: The command content is not encoded.
        /// *   Base64: The command content is Base64-encoded.
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
        /// The user group of the file. This parameter takes effect only on Linux instances. Default value: root.
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// The permissions on the file. This parameter takes effect only on Linux instances. You can configure this parameter in the same way as you configure the chmod command.
        /// 
        /// Default value: 0644, which indicates that the owner of the file has the read and write permissions on the file and that the user group of the file and other users have only the read permissions on the file.
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// The owner of the file. This parameter takes effect only on Linux instances. Default value: root.
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// The IDs of instances to which to send the file. A maximum of 50 instance IDs can be specified.
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
        /// The ID of the resource group for send files. When specify this parameter:
        /// 
        /// - The InstanceId of the ECS instance must belongs to the resource group.
        /// - Support via the parameter to filter out results of send file(via Call [DescribeSendFileResults](~~184117~~)).
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<SendFileRequestTag> Tag { get; set; }
        public class SendFileRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The destination directory on the instance to which to send the file. If the specified directory does not exist, the system creates the directory on the instance.
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// The timeout period for sending the file. Unit: seconds.
        /// 
        /// *   A timeout error occurs when a file cannot be sent because the process slows down or because a specific module or the Cloud Assistant client does not exist.
        /// *   If the specified timeout period is less than 10 seconds, the system automatically sets the timeout period to 10 seconds to ensure that the file is sent to the instances.
        /// 
        /// Default value: 60.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
