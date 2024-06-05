// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The name of the lifecycle policy. The name must be 3 to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

        /// <summary>
        /// The management rule that is associated with the lifecycle policy.
        /// 
        /// Valid values:
        /// 
        /// *   DEFAULT_ATIME_14: Files that are not accessed in the last 14 days are dumped to the IA storage medium.
        /// *   DEFAULT_ATIME_30: Files that are not accessed in the last 30 days are dumped to the IA storage medium.
        /// *   DEFAULT_ATIME_60: Files that are not accessed in the last 60 days are dumped to the IA storage medium.
        /// *   DEFAULT_ATIME_90: Files that are not accessed in the last 90 days are dumped to the IA storage medium.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LifecycleRuleName")]
        [Validation(Required=false)]
        public string LifecycleRuleName { get; set; }

        /// <summary>
        /// The absolute path of the directory that is associated with the lifecycle policy.
        /// 
        /// If you specify this parameter, you can associate the lifecycle policy with only one directory. The path must start with a forward slash (/) and must be a path that exists in the mount target.
        /// 
        /// > We recommend that you specify the Paths.N parameter so that you can associate the lifecycle policy with multiple directories.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The absolute paths of the directories that are associated with the lifecycle policy.
        /// 
        /// If you specify this parameter, you can associate the lifecycle policy with multiple directories. Each path must start with a forward slash (/) and must be a path that exists in the mount target. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// The storage type of the data that is dumped to the IA storage medium.
        /// 
        /// Default value: InfrequentAccess (IA).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
