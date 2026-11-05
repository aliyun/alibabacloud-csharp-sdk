// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222f91-57af-4907-87f1-f9046da4****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The periodic check time.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>The list of days when the policy cycle is monthly.</para>
        /// </summary>
        [NameInMap("DaysOfMonth")]
        [Validation(Required=false)]
        public List<int?> DaysOfMonth { get; set; }

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
        /// <para>The end time of the check time period, which indicates the hour of the day. The start time and end time of the query can only be selected from the following time intervals.</para>
        /// <list type="bullet">
        /// <item><description><b>0 to 6</b>: When the start time is 0, the end time must be set to 6 on the same day.</description></item>
        /// <item><description><b>6 to 12</b>: When the start time is 6, the end time must be set to 12 on the same day.</description></item>
        /// <item><description><b>12 to 18</b>: When the start time is 12, the end time must be set to 18 on the same day.</description></item>
        /// <item><description><b>18 to 24</b>: When the start time is 18, the end time must be set to 24 on the same day. The unit is hours (h).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The end time of the check, in seconds from 00:00:00 on the current day. Valid values: 1 to 86400. The value 86400 indicates 00:00:00 on the next day. This value is directly passed through from the database and is the only authoritative source for the exact window. For the system default policy (Frequency=6HOURLY) row, this value is always null (not 0), and callers must perform null checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32399</para>
        /// </summary>
        [NameInMap("EndTimeSeconds")]
        [Validation(Required=false)]
        public int? EndTimeSeconds { get; set; }

        /// <summary>
        /// <para>Indicates whether the requested ConfigId has a corresponding policy. When the value is false, the operation still returns a success response and the remaining configuration fields are empty. Callers should render an empty state based on this value and not rely on error codes.</para>
        /// </summary>
        [NameInMap("Exists")]
        [Validation(Required=false)]
        public bool? Exists { get; set; }

        /// <summary>
        /// <para>The frequency type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: daily</description></item>
        /// <item><description>WEEKLY: weekly</description></item>
        /// <item><description>MONTHLY: monthly</description></item>
        /// <item><description>6HOURLY: every 6 hours</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is the default policy.</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A3D5C8F-2A42-5477-BDD8-27E64B5F1739</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The check items selected in the policy.</para>
        /// </summary>
        [NameInMap("SelectedChecks")]
        [Validation(Required=false)]
        public List<GetCheckConfigResponseBodySelectedChecks> SelectedChecks { get; set; }
        public class GetCheckConfigResponseBodySelectedChecks : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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
        /// <para>The list of check item information.</para>
        /// </summary>
        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<GetCheckConfigResponseBodyStandards> Standards { get; set; }
        public class GetCheckConfigResponseBodyStandards : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud service configuration management</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The enabling status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ON</b>: Enabled.</description></item>
            /// <item><description><b>OFF</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RISK</b>: cloud service configuration management</description></item>
            /// <item><description><b>IDENTITY_PERMISSION</b>: identity and permission management</description></item>
            /// <item><description><b>COMPLIANCE</b>: compliance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RISK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The start time of the check time period, which indicates the hour of the day. The unit is hours (h).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The start time of the check, in seconds from 00:00:00 on the current day. Valid values: 0 to 86399. This value is directly passed through from the database and is the only authoritative source for the exact window. For the system default policy (Frequency=6HOURLY) row, this value is always null (not 0), and callers must perform null checks. Do not use the derived StartTime to reverse-engineer this value because the conversion is irreversible.</para>
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

    }

}
