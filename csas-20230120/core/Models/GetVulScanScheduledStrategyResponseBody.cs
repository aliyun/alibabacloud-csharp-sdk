// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVulScanScheduledStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the policy was created, in seconds-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786291200</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The effective scope specified by organizational structure. An empty list is returned if the scope is not configured by organizational structure.</para>
        /// </summary>
        [NameInMap("CustomMatchGroup")]
        [Validation(Required=false)]
        public List<GetVulScanScheduledStrategyResponseBodyCustomMatchGroup> CustomMatchGroup { get; set; }
        public class GetVulScanScheduledStrategyResponseBodyCustomMatchGroup : TeaModel {
            /// <summary>
            /// <para>The collection of organizational structure nodes.</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<string> Group { get; set; }

            /// <summary>
            /// <para>The identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-7c3f9a2e5b18****</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public string IdpId { get; set; }

        }

        /// <summary>
        /// <para>The time when the policy last triggered a scan, in seconds-level UNIX timestamp. The value 0 is returned if the policy has never been triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786291200</para>
        /// </summary>
        [NameInMap("LastTriggerTime")]
        [Validation(Required=false)]
        public long? LastTriggerTime { get; set; }

        /// <summary>
        /// <para>The matching mode of the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: The policy takes effect on all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: The policy takes effect only on users in specified user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs that the policy takes effect on. An empty list is returned when MatchMode is set to UserGroupAll.</para>
        /// </summary>
        [NameInMap("MatchTargetIds")]
        [Validation(Required=false)]
        public List<string> MatchTargetIds { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start hour during which the scan can be triggered. The value is a whole hour number. Valid values: 0 to 23, inclusive. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public int? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour during which the scan can be triggered. The value is a whole hour number. Valid values: 1 to 24, exclusive of the specified hour, and must be greater than ScanBeginTime. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ScanEndTime")]
        [Validation(Required=false)]
        public int? ScanEndTime { get; set; }

        /// <summary>
        /// <para>The unit of the trigger cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: by day.</description></item>
        /// <item><description><b>week</b>: by week.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("ScanFrequency")]
        [Validation(Required=false)]
        public string ScanFrequency { get; set; }

        /// <summary>
        /// <para>The interval number of the trigger cycle, which together with ScanFrequency determines the trigger cycle. Valid values: 1 to 30. For example, if ScanFrequency is set to week and ScanInterval is set to 1, the scan is triggered once a week.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanInterval")]
        [Validation(Required=false)]
        public int? ScanInterval { get; set; }

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
        /// <para>Execute vulnerability scanning on R&amp;D department endpoints every Sunday at midnight</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>The vulnerability scheduled scan policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul-scan-scheduled-strategy-8a3f6c2e91b7****</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly vulnerability scanning for R&amp;D Department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The list of exempted users. Users in this list are excluded from the scan of this policy. An empty list is returned if no exemption is configured.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
