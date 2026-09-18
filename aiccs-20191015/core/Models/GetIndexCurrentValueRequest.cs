// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetIndexCurrentValueRequest : TeaModel {
        /// <summary>
        /// <para>The list of department IDs. Separate multiple IDs with commas (,).</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2717975.html">GetAllDepartment</a> operation and check the <b>DepartmentId</b> parameter in the response to obtain the department ID.</para>
        /// <remarks>
        /// <para>When this parameter is not empty:</para>
        /// <list type="bullet">
        /// <item><description>If GroupIds is not empty, the query is performed based on the skill group list corresponding to GroupIds.</description></item>
        /// <item><description>If GroupIds is empty, the query is performed based on the department list corresponding to this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2332****,2334****</para>
        /// </summary>
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIds { get; set; }

        /// <summary>
        /// <para>The list of skill group IDs. Separate multiple IDs with commas (,).</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2717970.html">QuerySkillGroups</a> operation and check the <b>SkillGroupId</b> parameter in the response to obtain the skill group ID.</para>
        /// <remarks>
        /// <para>When this parameter is not empty, the query is performed based on the skill group list corresponding to this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2323****,2324****</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        /// <summary>
        /// <para>The AICCS instance ID. You can obtain the instance ID from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <remarks>
        /// <para>The AICCS instance ID is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
