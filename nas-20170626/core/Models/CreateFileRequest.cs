// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the portable account.
        /// Limits: The ID must be a 16-character string that contains only digits and lowercase English letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>378cc7630f26****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>Specifies whether to share directory permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Does not share directory permissions.</description></item>
        /// <item><description>true: Shares directory permissions.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when Type is set to Directory and Owner is not empty.</description></item>
        /// <item><description>The directory has inheritable Owner permissions. Subdirectories and files created in this directory inherit read and write permissions for this Owner, even if they are created by other users.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OwnerAccessInheritable")]
        [Validation(Required=false)]
        public bool? OwnerAccessInheritable { get; set; }

        /// <summary>
        /// <para>The absolute path of the directory or file.</para>
        /// <list type="bullet">
        /// <item><description>The path must start and end with a forward slash (/).</description></item>
        /// <item><description>The path must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>File: file</description></item>
        /// <item><description>Directory: directory</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
