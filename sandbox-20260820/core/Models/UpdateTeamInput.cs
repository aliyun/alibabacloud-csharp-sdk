// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateTeamInput : TeaModel {
        /// <summary>
        /// <para>The new description of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production sandbox environment for the algorithm team</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new plan specification of the team. Valid values: eco (economy), std (standard), pro (professional), ent (enterprise).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        /// <summary>
        /// <para>The ID of the new Alibaba Cloud resource group to which the team belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The new name of the team. The name can be modified only when allowUpdateTeamName of the team is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-prod</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

    }

}
