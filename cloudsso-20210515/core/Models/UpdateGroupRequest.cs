// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateGroupRequest : TeaModel {
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
        /// <para>The ID of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-00jqzghi2n3o5hkh****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The new description of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a group.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new name of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewTestGroup</para>
        /// </summary>
        [NameInMap("NewGroupName")]
        [Validation(Required=false)]
        public string NewGroupName { get; set; }

    }

}
