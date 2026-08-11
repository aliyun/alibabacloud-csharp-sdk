// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeGroupRefreshTaskRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Valid values: 1 to 500. Default value: 100. For more information about paging, set this parameter together with NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call. You do not need to set this parameter for the first request. This parameter is used to paginate through the node list in the current refresh task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the refresh task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-159136551662516768776</para>
        /// </summary>
        [NameInMap("NodeGroupRefreshTaskId")]
        [Validation(Required=false)]
        public string NodeGroupRefreshTaskId { get; set; }

        /// <summary>
        /// <para>The node refresh statuses to filter by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: the node is waiting to be refreshed.</description></item>
        /// <item><description>InProgress: the node is being refreshed.</description></item>
        /// <item><description>Success: the node is refreshed.</description></item>
        /// <item><description>Failed: the node failed to be refreshed.</description></item>
        /// <item><description>Skipped: all properties to be refreshed on the node exceeded the MaxDisruptiveAction constraint and were skipped.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public List<string> NodeStatuses { get; set; }

    }

}
