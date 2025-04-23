// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListMembersRequest : TeaModel {
        /// <summary>
        /// <para>The member name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The page number of the workspace list. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The roles that are used to filter members. Multiple roles are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI.AlgoDeveloper: algorithm developer</description></item>
        /// <item><description>PAI.AlgoOperator: algorithm O\&amp;M engineer</description></item>
        /// <item><description>PAI.LabelManager: labeling administrator</description></item>
        /// <item><description>PAI.MaxComputeDeveloper: MaxCompute developer</description></item>
        /// <item><description>PAI.WorkspaceAdmin: administrator</description></item>
        /// <item><description>PAI.WorkspaceGuest: guest</description></item>
        /// <item><description>PAI.WorkspaceOwner: owner</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAI.AlgoDeveloper</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public string Roles { get; set; }

    }

}
