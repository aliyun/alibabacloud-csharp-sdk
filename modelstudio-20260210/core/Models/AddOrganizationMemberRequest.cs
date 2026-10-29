// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class AddOrganizationMemberRequest : TeaModel {
        /// <summary>
        /// <para>The display name. If this parameter is not empty, the name field of the account is updated synchronously.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Account name</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The organization role code. Valid values: ORG_ADMIN and ORG_MEMBER. Default value: ORG_MEMBER.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORG_MEMBER</para>
        /// </summary>
        [NameInMap("OrgRoleCode")]
        [Validation(Required=false)]
        public string OrgRoleCode { get; set; }

        /// <summary>
        /// <para>The seat specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: Standard seat.</description></item>
        /// <item><description>pro: Pro seat.</description></item>
        /// <item><description>max: Premium seat.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
