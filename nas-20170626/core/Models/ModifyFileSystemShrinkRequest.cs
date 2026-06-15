// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyFileSystemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the file system.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The description must be 2 to 128 characters.</para>
        /// </description></item>
        /// <item><description><para>It must start with an uppercase or lowercase letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// </description></item>
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
        /// <item><description><para>General-purpose NAS: For example, <c>31a8e4****</c>.</para>
        /// </description></item>
        /// <item><description><para>Extreme NAS: The ID must start with <c>extreme-</c>. For example, <c>extreme-0015****</c>.</para>
        /// </description></item>
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>. For example, <c>cpfs-125487****</c>.</para>
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
        /// <para>Additional options for the file system.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string OptionsShrink { get; set; }

    }

}
