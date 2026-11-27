// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDirRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
        /// <para>The ID of the user group that owns the directory. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the user that owns the directory. Valid values: 0 to 4294967295.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The POSIX permissions applied to the root directory path. The value must be a valid octal number, such as 0755.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0755</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>Specifies whether to create multi-level directories. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): If the multi-level directories do not exist, the system creates them level by level.</description></item>
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
        /// <para>The name of the directory.</para>
        /// <list type="bullet">
        /// <item><description>Must start with a forward slash (/).</description></item>
        /// <item><description>Supports digits, uppercase letters, and lowercase letters.</description></item>
        /// <item><description>Can contain underscores (_), hyphens (-), or periods (.).</description></item>
        /// <item><description>The path cannot contain symbolic links, such as the current directory (.), the parent directory (..), or other symbolic links.<remarks>
        /// <list type="bullet">
        /// <item><description>If the root directory does not exist, you must configure the automatic creation information. The system automatically creates the specified root directory based on the settings.</description></item>
        /// <item><description>If the root directory already exists, you do not need to configure the automatic creation information. If you configure it, the configurations in the automatic creation information are ignored.</description></item>
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
