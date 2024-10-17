// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 64 characters in length.</description></item>
        /// <item><description>The name must start with a letter and can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>The description of the permission group.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>By default, the description of the permission group is the same as the name of the permission group. The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS file system</description></item>
        /// <item><description>extreme: Extreme NAS file system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

    }

}
