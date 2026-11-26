// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the group.</para>
        /// <para>Length: The description can be up to 1024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a group.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The name of the group.</para>
        /// <para>Format: The name can contain letters, digits, and the special characters <c>_-.</c>.</para>
        /// <para>Length: The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
