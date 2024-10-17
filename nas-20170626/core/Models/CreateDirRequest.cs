// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDirRequest : TeaModel {
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
        /// <para>The ID of the owner group for the directory. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The owner ID for the directory. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The Portable Operating System Interface (POSIX) permissions applied to the root directory. The value is a valid octal number, such as 0755.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0755</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a multi-level directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): If no multi-level directory exists, directories are created level by level.</description></item>
        /// <item><description>false: Only the last level of directory is created. An error message is returned because the parent directory does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Recursion")]
        [Validation(Required=false)]
        public bool? Recursion { get; set; }

        /// <summary>
        /// <para>The directory name.</para>
        /// <list type="bullet">
        /// <item><description>The directory must start with a forward slash (/).</description></item>
        /// <item><description>The directory can contain digits and letters.</description></item>
        /// <item><description>The directory can contain underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The directory cannot contain symbolic links, such as the current directory (.), the upper-level directory (..), and other symbolic links.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the root directory does not exist, configure the information for directory creation. The system then automatically creates the specified root directory based on your settings.</description></item>
        /// <item><description>If the root directory exists, you do not need to configure the information for directory creation. The configurations for directory creation are ignored even if you configure the information.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

    }

}
