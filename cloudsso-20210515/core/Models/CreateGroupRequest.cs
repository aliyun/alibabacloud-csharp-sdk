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
        /// <para>The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a group.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The name of the group.</para>
        /// <para>The name can contain letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
