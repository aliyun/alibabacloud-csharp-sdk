// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_2bo6lefcewdausyyxxxx</para>
        /// </summary>
        [NameInMap("groupExternalId")]
        [Validation(Required=false)]
        public string GroupExternalId { get; set; }

        /// <summary>
        /// <para>The organization name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name001</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
