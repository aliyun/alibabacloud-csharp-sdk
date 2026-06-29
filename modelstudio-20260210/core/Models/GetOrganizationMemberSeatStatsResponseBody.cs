// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetOrganizationMemberSeatStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of administrators (ORG_ADMIN role).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AdminRoleUserCount")]
        [Validation(Required=false)]
        public int? AdminRoleUserCount { get; set; }

        /// <summary>
        /// <para>The number of regular members (ORG_MEMBER role).</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MemberRoleUserCount")]
        [Validation(Required=false)]
        public int? MemberRoleUserCount { get; set; }

        /// <summary>
        /// <para>The organization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ffd468b1e45db3c1cc26ad6</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>The number of owner accounts (ORG_OWNER role).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnerRoleUserCount")]
        [Validation(Required=false)]
        public int? OwnerRoleUserCount { get; set; }

        /// <summary>
        /// <para>The number of members with assigned seats.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SeatedMemberCount")]
        [Validation(Required=false)]
        public int? SeatedMemberCount { get; set; }

        /// <summary>
        /// <para>The total number of members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalMemberCount")]
        [Validation(Required=false)]
        public int? TotalMemberCount { get; set; }

        /// <summary>
        /// <para>The number of members without assigned seats.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UnseatedMemberCount")]
        [Validation(Required=false)]
        public int? UnseatedMemberCount { get; set; }

    }

}
