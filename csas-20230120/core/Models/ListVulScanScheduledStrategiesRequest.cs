// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVulScanScheduledStrategiesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
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
        /// <item><description><b>UserGroupAll</b>: Takes effect for all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Takes effect only for users in specified user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by enabled status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of scheduled vulnerability scan policies used for filtering. A maximum of 100 IDs can be specified. Duplicate IDs are not allowed.</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public List<string> StrategyIds { get; set; }

        /// <summary>
        /// <para>The policy name. Fuzzy match is supported. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly vulnerability scanning for R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The user group ID. Used to filter records whose effective scope includes the specified user group. You can obtain the value from the following operation:</para>
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
