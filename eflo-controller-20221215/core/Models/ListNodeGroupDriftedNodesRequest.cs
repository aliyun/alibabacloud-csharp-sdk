// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNodeGroupDriftedNodesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Valid values: 1 to 500. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call. You do not need to set this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3525</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>Limits the check scope. If not specified, all nodes in the node group are checked. <warning>If the model is a super node, pass the TrayNode ID.</warning></para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

    }

}
