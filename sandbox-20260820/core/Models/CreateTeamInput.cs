// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTeamInput : TeaModel {
        /// <summary>
        /// <para>The description of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sandbox environment for the algorithm team</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The plan specification of the team. Valid values: eco (economy), std (standard), pro (professional), ent (enterprise).</para>
        /// 
        /// <b>Example:</b>
        /// <para>std</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the team belongs. If this parameter is not specified, the default resource group of the account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The name of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-dev</para>
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

    }

}
