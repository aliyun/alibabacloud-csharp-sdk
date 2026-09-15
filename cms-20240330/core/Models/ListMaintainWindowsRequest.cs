// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListMaintainWindowsRequest : TeaModel {
        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// <item><description><b>desc</b>: descending order (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Filters results by enabled status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Returns only enabled silence policies.</description></item>
        /// <item><description><b>false</b>: Returns only paused silence policies.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, results are not filtered by enabled status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The ID of the silence policy. Exact match is used. If you do not specify this parameter, results are not filtered by ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ff3fbd0-8a0b-4b31-9b1c-8e3f0a2c5d71</para>
        /// </summary>
        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>Policy Name of the silence policy. Fuzzy match is used (a match occurs if Policy Name contains the specified value). If you do not specify this parameter, results are not filtered by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>silence-for-release</para>
        /// </summary>
        [NameInMap("maintainWindowName")]
        [Validation(Required=false)]
        public string MaintainWindowName { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in this request. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You do not need to specify this parameter for the first query. For subsequent queries, set this parameter to the non-empty nextToken value returned in the previous response. This value does not guarantee that the next page contains data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y21zRXZlbnRCYXNlUGFnZT0x</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The field by which to sort results. Default value: createTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>createTime</b>: creation time.</description></item>
        /// <item><description><b>updateTime</b>: update time.</description></item>
        /// <item><description><b>enable</b>: enabled status.</description></item>
        /// </list>
        /// <para>If you specify any other value, results are sorted by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createTime</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The workspace name. This parameter is required by the backend and is used to isolate silence policy resources across different business workspaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
