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
        /// <para>The ID of the lifecycle policy.</para>
        /// 
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
        /// <item><description>DEFAULT_ATIME_14: Files not accessed for 14 days.</description></item>
        /// <item><description>DEFAULT_ATIME_30: Files not accessed for 30 days.</description></item>
        /// <item><description>DEFAULT_ATIME_60: Files not accessed for 60 days.</description></item>
        /// <item><description>DEFAULT_ATIME_90: Files not accessed for 90 days.</description></item>
        /// <item><description>DEFAULT_ATIME_180: Files not accessed for 180 days. DEFAULT_ATIME_180 is supported only when the StorageType parameter is set to Archive.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If an IA policy has already been set for the directory, any subsequent archival policy must have a longer duration than the IA policy.</para>
        /// </remarks>
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
        /// <para>The storage class.</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: the Infrequent Access (IA) storage class.</description></item>
        /// <item><description>Archive: the Archive storage class.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
