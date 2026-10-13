// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDirRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The user group ID of the directory owner. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The user ID of the directory owner. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The POSIX permissions to apply to the root directory path. The value is a valid octal number, such as 0755.</para>
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
        /// <item><description>true (default): If the multi-level directory does not exist, the system creates the directories level by level.</description></item>
        /// <item><description>false: Only the last-level directory is created. If the parent directory does not exist, an error message is returned.</description></item>
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
        /// <item><description>The name must start with a forward slash (/).</description></item>
        /// <item><description>The name can contain digits and uppercase and lowercase letters.</description></item>
        /// <item><description>The name can contain underscores (_), hyphens (-), or periods (.).</description></item>
        /// <item><description>The path cannot contain symbolic links, such as the current directory (.), the parent directory (..), or other symbolic links.<remarks>
        /// <list type="bullet">
        /// <item><description>If the root directory does not exist, configure the automatic creation information. The system automatically creates the specified root directory based on the settings.</description></item>
        /// <item><description>If the root directory already exists, you do not need to configure the automatic creation information. If you configure the information, the automatic creation settings are ignored.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

    }

}
