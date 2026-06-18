// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListAgentBySkillGroupIdRequest : TeaModel {
        /// <summary>
        /// <para>A unique ID for the Customer request. It is used for idempotency validation and can be generated using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-9b11-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The Artificial Intelligence Cloud Call Service (AICCS) instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The skill group ID.<br>You can invoke the <a href="https://help.aliyun.com/zh/aiccs/developer-reference/api-aiccs-2019-10-15-queryskillgroups">QuerySkillGroups</a> API and view the <b>SkillGroupId</b> in the response parameters to obtain the skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>666666</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public long? SkillGroupId { get; set; }

    }

}
