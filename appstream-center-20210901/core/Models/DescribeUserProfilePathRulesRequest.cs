// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeUserProfilePathRulesRequest : TeaModel {
        /// <summary>
        /// <para>The app instance group ID. Specify either this parameter or AppInstanceGroupSetId when querying app instance group rules. This parameter can be omitted when querying system default rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-0bi83v****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The app instance group set ID. Specify either this parameter or AppInstanceGroupId when querying app instance group set rules. This parameter can be omitted when querying system default rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The region ID of the request. When querying or setting rules for a specified app instance group, use the region where the target app instance group is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The path rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: Queries system default rules. Both target IDs can be omitted.</description></item>
        /// <item><description><c>AppInstanceGroup</c>: Queries the rules of an app instance group or an app instance group set.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroup</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
