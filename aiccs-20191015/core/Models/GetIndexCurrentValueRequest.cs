// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetIndexCurrentValueRequest : TeaModel {
        /// <summary>
        /// <para>List of department IDs. Separate multiple IDs with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2717975.html">GetAllDepartment</a> API and check the <b>DepartmentId</b> field in the response to obtain department IDs.</para>
        /// <remarks>
        /// <para>When this parameter is not empty:  </para>
        /// <list type="bullet">
        /// <item><description>If GroupIds is not empty, the system prioritizes querying data metrics for the skill groups specified by GroupIds.  </description></item>
        /// <item><description>If GroupIds is empty, the system prioritizes querying data metrics for the departments specified by this parameter.</description></item>
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
        /// <para>List of skill group IDs. Separate multiple IDs with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2717970.html">QuerySkillGroups</a> API and check the <b>SkillGroupId</b> field in the response to obtain skill group IDs.</para>
        /// <remarks>
        /// <para>When this parameter is not empty, the system prioritizes querying data metrics for the specified skill groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2323****,2324****</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        /// <summary>
        /// <para>Artificial Intelligence Cloud Call Service (AICCS) instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
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
