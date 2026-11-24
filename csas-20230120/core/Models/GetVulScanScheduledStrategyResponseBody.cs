// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVulScanScheduledStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the policy was created. The value is a UNIX timestamp accurate to seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786291200</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The effective scope specified by organizational structure. If no organizational structure is configured, an empty list is returned.</para>
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
            /// <para>The ID of the identity source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-7c3f9a2e5b18****</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public string IdpId { get; set; }

        }

        /// <summary>
        /// <para>The time when the policy last triggered a scan. The value is a UNIX timestamp accurate to seconds. If the policy has never been triggered, 0 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786291200</para>
        /// </summary>
        [NameInMap("LastTriggerTime")]
        [Validation(Required=false)]
        public long? LastTriggerTime { get; set; }

        /// <summary>
        /// <para>The matching mode for the effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Applies only to users in the specified user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The collection of effective user group IDs. If MatchMode is set to UserGroupAll, an empty list is returned.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start hour when a scan is allowed to be triggered. The value must be an integer on the hour. Valid values: 0 to 23. The specified hour is included. This field is not a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanBeginTime")]
        [Validation(Required=false)]
        public int? ScanBeginTime { get; set; }

        /// <summary>
        /// <para>The end hour when a scan is allowed to be triggered. The value must be an integer on the hour. Valid values: 1 to 24. The specified hour is excluded and must be greater than the value of ScanBeginTime. This field is not a timestamp.</para>
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
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execute vulnerability scanning for R&amp;D department endpoints every Sunday morning</para>
        /// </summary>
        [NameInMap("StrategyDescription")]
        [Validation(Required=false)]
        public string StrategyDescription { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled vulnerability scanning policy.</para>
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
        /// <para>Weekly vulnerability scanning for the R&amp;D department</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The whitelist of users. Scans based on this policy are not performed on the users in the whitelist. If no whitelist is configured, an empty list is returned.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
