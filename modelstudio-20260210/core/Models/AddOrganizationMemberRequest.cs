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
        /// <para>账号名称</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The organization role code. Only ORG_ADMIN or ORG_MEMBER is allowed. Default value: ORG_MEMBER.</para>
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
        /// <item><description>standard: standard seat.</description></item>
        /// <item><description>pro: premium seat.</description></item>
        /// <item><description>max: exclusive seat.</description></item>
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
