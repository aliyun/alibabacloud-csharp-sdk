// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class AddOrganizationMemberRequest : TeaModel {
        /// <summary>
        /// <para>The display name. If this parameter is not empty, the name field of the account is also updated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>账号名称</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The account information of the TokenPlan management platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc_123456789</para>
        /// </summary>
        [NameInMap("CallerUacAccountId")]
        [Validation(Required=false)]
        public string CallerUacAccountId { get; set; }

        /// <summary>
        /// <para>The product namespace ID. For the TokenPlan product, this field is fixed to namespace-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace-1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The organization ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org_123456789</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

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
        /// <para>The seat specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
