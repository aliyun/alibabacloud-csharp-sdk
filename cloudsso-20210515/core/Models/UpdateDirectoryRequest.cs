// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new name of the directory. The name must be globally unique.</para>
        /// <para>The name can contain lowercase letters, digits, and hyphens (-). The name cannot start or end with a hyphen (-) and cannot have two consecutive hyphens (-). If you want to start the new name of the directory starts with <c>d-</c>, you must set this parameter to the ID of the directory.</para>
        /// <para>The name must be 2 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new-example</para>
        /// </summary>
        [NameInMap("NewDirectoryName")]
        [Validation(Required=false)]
        public string NewDirectoryName { get; set; }

    }

}
