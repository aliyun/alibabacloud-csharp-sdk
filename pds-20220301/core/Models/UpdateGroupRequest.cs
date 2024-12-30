// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the group after modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test group description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the group that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e43ec8427dd45f19431b7504649a1b4</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the group after modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test group</para>
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
