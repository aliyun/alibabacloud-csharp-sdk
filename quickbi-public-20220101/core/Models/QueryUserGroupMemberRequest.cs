// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>Keyword for the username or nickname of the user group member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>User group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
