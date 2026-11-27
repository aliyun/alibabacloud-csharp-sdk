// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class RemoveAgentFromSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of agent IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public List<long?> AgentIds { get; set; }

        /// <summary>
        /// <para>The AICCS instance ID.
        /// You can obtain the ID from the <b>Instances</b> page in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-78v1gnp97002</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The skill group ID.</para>
        /// <para>You can call the <a href="https://www.alibabacloud.com/help/en/aiccs/developer-reference/api-aiccs-2019-10-15-queryskillgroups">QuerySkillGroups</a> operation and view the <b>SkillGroupId</b> parameter in the response to obtain the skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1146****</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public long? SkillGroupId { get; set; }

    }

}
