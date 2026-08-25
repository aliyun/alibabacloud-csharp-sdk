// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanTasksRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in paging. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end point for filtering by task expiration time. The value is a UNIX timestamp in seconds. The value must be greater than StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1762135466</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The collection of scan performance modes. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("PerformanceModes")]
        [Validation(Required=false)]
        public List<string> PerformanceModes { get; set; }

        /// <summary>
        /// <para>The collection of scan path scopes. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("ScanModes")]
        [Validation(Required=false)]
        public List<string> ScanModes { get; set; }

        /// <summary>
        /// <para>The start point for filtering by task expiration time. The value is a UNIX timestamp in seconds. This parameter must be specified together with EndTime. Specifying this parameter alone does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754150421</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not canceled. This is the default value.</description></item>
        /// <item><description><b>1</b>: Canceled.</description></item>
        /// <item><description><b>-1</b>: No status filter. All tasks are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The collection of virus scan task IDs. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>The user group ID, used to filter tasks whose effective scope includes the specified user group. You can obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: Lists user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-9d4f2a7b3c1e****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
