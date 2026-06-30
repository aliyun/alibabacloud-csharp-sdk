// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateOrganizationMemberRequest : TeaModel {
        /// <summary>
        /// <para>The list of account IDs for batch operations.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The code of the new role. When you perform a batch operation, all specified accounts are changed to this role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORG_MEMBER</para>
        /// </summary>
        [NameInMap("NewRoleCode")]
        [Validation(Required=false)]
        public string NewRoleCode { get; set; }

    }

}
