// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListMembersRequest : TeaModel {
        /// <summary>
        /// <para>Username. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>Page number. Pages start at 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Roles used to filter members. Separate multiple roles with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PAI.AlgoDeveloper: Algorithm developer</para>
        /// </description></item>
        /// <item><description><para>PAI.AlgoOperator: Algorithm O\&amp;M engineer</para>
        /// </description></item>
        /// <item><description><para>PAI.LabelManager: Annotation administrator</para>
        /// </description></item>
        /// <item><description><para>PAI.MaxComputeDeveloper: MaxCompute developer</para>
        /// </description></item>
        /// <item><description><para>PAI.WorkspaceAdmin: Workspace administrator</para>
        /// </description></item>
        /// <item><description><para>PAI.WorkspaceGuest: Guest</para>
        /// </description></item>
        /// <item><description><para>PAI.WorkspaceOwner: Workspace owner</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAI.AlgoDeveloper</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public string Roles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2788******129</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
