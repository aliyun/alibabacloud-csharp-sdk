// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of check items to be added to the policy.
        /// <notice> If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect. </notice></para>
        /// </summary>
        [NameInMap("AddedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestAddedCheck> AddedCheck { get; set; }
        public class ChangeCheckConfigRequestAddedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the check item ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The section ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public long? SectionId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222f91-57af-4907-87f1-f9046da*****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>Configures the check policy by using the IDs of the specified regulations.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the regulation IDs. If the ConfigStandardIds parameter is configured, this parameter does not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigRequirementIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigRequirementIds ConfigRequirementIds { get; set; }
        public class ChangeCheckConfigRequestConfigRequirementIds : TeaModel {
            /// <summary>
            /// <para>The list of regulation IDs to be added to the policy.</para>
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// <para>The list of regulation IDs to be removed from the policy.</para>
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// <para>Configures the check policy by using the IDs of the specified standards.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the standard IDs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigStandardIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigStandardIds ConfigStandardIds { get; set; }
        public class ChangeCheckConfigRequestConfigStandardIds : TeaModel {
            /// <summary>
            /// <para>The list of standard IDs to be added to the policy.</para>
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// <para>The list of standard IDs to be removed from the policy.</para>
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// <para>The field configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: Adds all check items.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Configure")]
        [Validation(Required=false)]
        public string Configure { get; set; }

        /// <summary>
        /// <para>The periodic check time.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>The list of days of the month when the policy cycle is monthly.</para>
        /// </summary>
        [NameInMap("DaysOfMonth")]
        [Validation(Required=false)]
        public List<int?> DaysOfMonth { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only checks the request without performing the actual operation.</description></item>
        /// <item><description>false: Executes the request normally.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to check new check items by default when new check items are added to the selected regulations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic periodic checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// <para>The end time of the check time period, which indicates the hour of the day. The start time and end time must be selected from the following time intervals. Valid values: 6, 12, 18, and 24.</para>
        /// <list type="bullet">
        /// <item><description><b>0~6</b>: If the start time is 0, the end time must be set to 6 on the same day.</description></item>
        /// <item><description><b>6~12</b>: If the start time is 6, the end time must be set to 12 on the same day.</description></item>
        /// <item><description><b>12~18</b>: If the start time is 12, the end time must be set to 18 on the same day.</description></item>
        /// <item><description><b>18~24</b>: If the start time is 18, the end time must be set to 24 on the same day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The end time of the check, in seconds from 00:00:00 of the current day. Valid values: 1 to 86400, where 86400 indicates 00:00:00 of the next day. This parameter is optional. If this parameter is not provided, the current value of the policy is retained. This parameter must be paired with StartTimeSeconds. If only one of them is provided, the system returns IllegalParam (paramName=scheduleTime). If both this parameter and StartTime/EndTime are provided, the second-level parameters take precedence, and the hour-level parameters are ignored. The time window span must not be less than 60 seconds. This parameter is not accepted for the system default policy (ConfigId=default) and will be rejected if provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32399</para>
        /// </summary>
        [NameInMap("EndTimeSeconds")]
        [Validation(Required=false)]
        public int? EndTimeSeconds { get; set; }

        /// <summary>
        /// <para>The frequency type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: Daily.</description></item>
        /// <item><description>WEEKLY: Weekly.</description></item>
        /// <item><description>MONTHLY: Monthly.</description></item>
        /// <item><description>6HOURLY: Every 6 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The region of the Security Center instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Center</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of check items to be removed from the policy.
        /// <notice> If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect. </notice></para>
        /// </summary>
        [NameInMap("RemovedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestRemovedCheck> RemovedCheck { get; set; }
        public class ChangeCheckConfigRequestRemovedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the check item ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The section ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public long? SectionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the member accounts in the resource folder, which is an Alibaba Cloud account ID.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and can be ignored.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>The start time of the check time period, which indicates the hour of the day. The start time and end time must be selected from the following time intervals. Valid values: 0, 6, 12, and 18.</para>
        /// <list type="bullet">
        /// <item><description><b>0~6</b>: If the start time is 0, the end time must be set to 6 on the same day.</description></item>
        /// <item><description><b>6~12</b>: If the start time is 6, the end time must be set to 12 on the same day.</description></item>
        /// <item><description><b>12~18</b>: If the start time is 12, the end time must be set to 18 on the same day.</description></item>
        /// <item><description><b>18~24</b>: If the start time is 18, the end time must be set to 24 on the same day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The start time of the check, in seconds from 00:00:00 of the current day. Valid values: 0 to 86399, which correspond to 00:00:00 to 23:59:59. This parameter is optional. If this parameter is not provided, the current value of the policy is retained. This parameter must be paired with EndTimeSeconds. If only one of them is provided, the system returns IllegalParam (paramName=scheduleTime). If both this parameter and StartTime/EndTime are provided, the second-level parameters take precedence, and the hour-level parameters are ignored. If the two sets of parameters are inconsistent, the server records a WARN log. The time window span must not be less than 60 seconds. The frequency of the system default policy (ConfigId=default) is always 6HOURLY. This parameter is not accepted for the default policy and will be rejected if provided. Under a multi-policy frequency, the actual scan execution time is exactly the second specified by this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25200</para>
        /// </summary>
        [NameInMap("StartTimeSeconds")]
        [Validation(Required=false)]
        public int? StartTimeSeconds { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the automatically generated system configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SystemConfig")]
        [Validation(Required=false)]
        public bool? SystemConfig { get; set; }

        /// <summary>
        /// <para>The list of cloud providers.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
