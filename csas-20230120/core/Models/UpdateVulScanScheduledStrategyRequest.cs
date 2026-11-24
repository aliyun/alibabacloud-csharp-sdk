// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVulScanScheduledStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The matching mode for the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Applies only to users in specified user groups. If this value is specified, UserGroupIds is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The policy priority. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The start hour when a scan can be triggered. The value must be an integer on the hour. Valid values: 0 to 23, inclusive. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public string ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour when a scan can be triggered. The value must be an integer on the hour. Valid values: 1 to 24, exclusive. The value must be greater than the value of ScanBeginTime. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ScanEndTime")]
        [Validation(Required=false)]
        public string ScanEndTime { get; set; }

        /// <summary>
        /// <para>The unit of the trigger cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: Day.</description></item>
        /// <item><description><b>week</b>: Week.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("ScanFrequency")]
        [Validation(Required=false)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// <para>The interval of the trigger cycle. This parameter and ScanFrequency determine the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, a scan is performed once a week.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanInterval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
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
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execute vulnerability scanning on R&amp;D department endpoints every Sunday morning</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled vulnerability scan policy to be modified. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVulScanScheduledStrategies~~">ListVulScanScheduledStrategies</a>: Queries scheduled vulnerability scan policies.</description></item>
        /// <item><description><a href="~~CreateVulScanScheduledStrategy~~">CreateVulScanScheduledStrategy</a>: Creates a scheduled vulnerability scan policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul-scan-scheduled-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The policy name. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly vulnerability scanning for the R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups to which the policy applies. This parameter is required when MatchMode is set to UserGroupNormal and cannot be specified when MatchMode is set to UserGroupAll. You can specify 1 to 100 user group IDs, and the IDs cannot be duplicated. The specified IDs overwrite the existing user groups of the policy.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user whitelist. Users in the whitelist are excluded from the scan of this policy. The whitelist can contain up to 1,000 users and cannot contain duplicates. This parameter overwrites the existing whitelist of the policy.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
