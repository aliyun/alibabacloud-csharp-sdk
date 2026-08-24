// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVulScanTasksRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>Filters by the matching mode of the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: applies only to users within specified user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the vulnerability scheduled scan policy. This parameter is used to filter tasks triggered by the specified policy. Valid values are obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVulScanScheduledStrategies~~">ListVulScanScheduledStrategies</a>: lists vulnerability scheduled scan policies.</description></item>
        /// <item><description><a href="~~CreateVulScanScheduledStrategy~~">CreateVulScanScheduledStrategy</a>: creates a vulnerability scheduled scan policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vul-scan-scheduled-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("ScheduledStrategyId")]
        [Validation(Required=false)]
        public string ScheduledStrategyId { get; set; }

        /// <summary>
        /// <para>Filters by task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Running</b>: the task is in progress and still within the validity period.</description></item>
        /// <item><description><b>Expired</b>: the task has expired and exceeded the validity period.</description></item>
        /// <item><description><b>Canceled</b>: the task has been canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The vulnerability scanning task IDs used for filtering. A maximum of 100 IDs can be specified. Duplicate IDs are not allowed.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>The task name. Fuzzy match is supported. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D department vulnerability scanning</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Filters by task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instant</b>: an instant task created by CreateVulScanTask.</description></item>
        /// <item><description><b>Scheduled</b>: a scheduled task automatically created by a vulnerability scheduled scan policy on a periodic basis.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instant</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The user group ID. This parameter is used to filter records whose effective scope includes the specified user group. Valid values are obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: lists user groups.</description></item>
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
