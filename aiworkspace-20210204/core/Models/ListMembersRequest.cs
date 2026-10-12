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
        /// <para>The page number of the workspace list. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters members by role. Separate multiple roles with commas (,).
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI.AlgoDeveloper: Algorithm developer.</description></item>
        /// <item><description>PAI.AlgoOperator: Algorithm O&amp;M.</description></item>
        /// <item><description>PAI.LabelManager: Labeling administrator.</description></item>
        /// <item><description>PAI.MaxComputeDeveloper: MaxCompute developer.</description></item>
        /// <item><description>PAI.WorkspaceAdmin: Administrator.</description></item>
        /// <item><description>PAI.WorkspaceGuest: Guest.</description></item>
        /// <item><description>PAI.WorkspaceOwner: Owner.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAI.AlgoDeveloper</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public string Roles { get; set; }

        /// <summary>
        /// <para>The ID of the user to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2788******129</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
