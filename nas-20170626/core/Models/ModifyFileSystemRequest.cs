// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The description of the file system.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAS-test-1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Sample ID of a General-purpose NAS file system: <c>31a8e4****</c>.</description></item>
        /// <item><description>The IDs of Extreme NAS file systems must start with <c>extreme-</c>. Example: <c>extreme-0015****</c>.</description></item>
        /// <item><description>The IDs of Cloud Paralleled File System (CPFS) file systems must start with <c>cpfs-</c>. Example: <c>cpfs-125487****</c>.<remarks>
        /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The options.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ModifyFileSystemRequestOptions Options { get; set; }
        public class ModifyFileSystemRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the oplock feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the feature.</description></item>
            /// <item><description>false: disables the feature.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Only Server Message Block (SMB) file systems support this feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableOplock")]
            [Validation(Required=false)]
            public bool? EnableOplock { get; set; }

        }

    }

}
