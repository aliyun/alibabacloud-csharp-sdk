// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class RemoveSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the client request. This parameter is used to ensure the idempotence of the request. You can use a UUID to generate the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-****-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The AICCS instance ID. You can obtain the ID from the <b>Instances</b> page in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The skill group ID. You can call the <a href="https://www.alibabacloud.com/help/en/aiccs/developer-reference/api-aiccs-2019-10-15-queryskillgroups">QuerySkillGroups</a> operation and view the <b>SkillGroupId</b> response parameter to obtain the skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
