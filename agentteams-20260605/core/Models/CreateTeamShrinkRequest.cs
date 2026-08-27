// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateTeamShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The team administrator name. The administrator must be an existing user under the instance with sufficient permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin-user</para>
        /// </summary>
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>The idempotency token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The team description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a team.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentteams-test-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The team name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker-demo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The initial member list of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("TeamMembers")]
        [Validation(Required=false)]
        public string TeamMembersShrink { get; set; }

    }

}
