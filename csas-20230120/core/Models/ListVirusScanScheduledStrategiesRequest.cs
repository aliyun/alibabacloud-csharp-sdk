// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanScheduledStrategiesRequest : TeaModel {
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
        /// <para>Filters policies by enabled status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of virus scheduled scan policy IDs. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public List<string> StrategyIds { get; set; }

        /// <summary>
        /// <para>The policy name. Fuzzy match is supported. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly_Scan_DevTeam</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The user group ID. This parameter is used to filter policies whose effective scope includes the specified user group. You can obtain the value from:</para>
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
