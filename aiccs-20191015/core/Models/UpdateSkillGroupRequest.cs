// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>Unique ID of the customer request. Used for idempotency validation. You can generate it by using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-****-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Skill group description.  </para>
        /// <remarks>
        /// <para>This parameter can be updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>自动化测试</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name of the skill group.  </para>
        /// <remarks>
        /// <para>This parameter can be updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>自动化测试</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>AICCS instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Skill group ID.  </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/zh/aiccs/developer-reference/api-aiccs-2019-10-15-queryskillgroups">QuerySkillGroups</a> API and check the <b>SkillGroupId</b> field in the response to obtain the skill group ID.  </para>
        /// <remarks>
        /// <para>This parameter cannot be updated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public long? SkillGroupId { get; set; }

        /// <summary>
        /// <para>Skill group name.  </para>
        /// <remarks>
        /// <para>This parameter cannot be updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>自动化测试</para>
        /// </summary>
        [NameInMap("SkillGroupName")]
        [Validation(Required=false)]
        public string SkillGroupName { get; set; }

    }

}
