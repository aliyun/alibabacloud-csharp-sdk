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
        /// <para>The ID of the portable account. The ID must be a 16-digit string. The string can contain digits and lowercase letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>378cc7630f26****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>Specifies whether to share the directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not share the directory.</description></item>
        /// <item><description>true: shares the directory.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if the Type parameter is set to Directory and the Owner parameter is not empty.</description></item>
        /// <item><description>The permissions on a directory can be inherited by the owner. The owner has read and write permissions on the subdirectories and subfiles created in the directory, even if they are created by others.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OwnerAccessInheritable")]
        [Validation(Required=false)]
        public bool? OwnerAccessInheritable { get; set; }

        /// <summary>
        /// <para>The absolute path of the directory or file. The path must start and end with a forward slash (/) and must be 2 to 1024 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>File</description></item>
        /// <item><description>Directory</description></item>
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
