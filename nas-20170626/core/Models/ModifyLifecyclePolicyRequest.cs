// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lc-xxx</para>
        /// </summary>
        [NameInMap("LifecyclePolicyId")]
        [Validation(Required=false)]
        public string LifecyclePolicyId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle policy.</para>
        /// <para>The name must be 3 to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclepolicy_01</para>
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

        /// <summary>
        /// <para>The management rule that is associated with the lifecycle policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT_ATIME_14: Files that are not accessed in the last 14 days are dumped to the IA storage medium.</description></item>
        /// <item><description>DEFAULT_ATIME_30: Files that are not accessed in the last 30 days are dumped to the IA storage medium.</description></item>
        /// <item><description>DEFAULT_ATIME_60: Files that are not accessed in the last 60 days are dumped to the IA storage medium.</description></item>
        /// <item><description>DEFAULT_ATIME_90: Files that are not accessed in the last 90 days are dumped to the IA storage medium.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_ATIME_14</para>
        /// </summary>
        [NameInMap("LifecycleRuleName")]
        [Validation(Required=false)]
        public string LifecycleRuleName { get; set; }

        /// <summary>
        /// <para>The absolute path of a directory with which the lifecycle policy is associated.</para>
        /// <para>The path must start with a forward slash (/) and must be a path that exists in the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/pathway/to/folder</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The storage type of the data that is dumped to the IA storage medium.</para>
        /// <para>Default value: InfrequentAccess (IA).</para>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
