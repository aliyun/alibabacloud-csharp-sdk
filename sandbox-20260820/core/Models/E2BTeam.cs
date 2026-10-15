// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BTeam : TeaModel {
        /// <summary>
        /// <para>Specifies whether the team name can be modified. The default team does not allow modification.</para>
        /// </summary>
        [NameInMap("allowUpdateTeamName")]
        [Validation(Required=false)]
        public bool? AllowUpdateTeamName { get; set; }

        /// <summary>
        /// <para>The creation time of the team in UTC, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T08:30:00Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The team description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sandbox environment for the algorithm team</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The team plan specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eco: economy.</description></item>
        /// <item><description>std: standard.</description></item>
        /// <item><description>pro: professional.</description></item>
        /// <item><description>ent: enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>std</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        /// <summary>
        /// <para>Indicates whether the current caller has read-only access to the team. If the value is true, the team configuration cannot be modified.</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the team belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The team status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: Normal.</description></item>
        /// <item><description>deleting: Being deleted.</description></item>
        /// <item><description>delete_failed: Failed to delete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the resource belongs, in UUID format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The team name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-dev</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The user ID of the team creator, in UUID format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c1d4e72-****</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
