// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the directory. The name must be globally unique.</para>
        /// <para>Format: The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-) and cannot contain two consecutive hyphens (-). It cannot start with <c>d-</c>.</para>
        /// <para>Length: 2 to 64 characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically generates a name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

    }

}
