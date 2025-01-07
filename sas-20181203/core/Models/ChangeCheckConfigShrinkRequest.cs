// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of check items that you want to add to the policy.</para>
        /// <remarks>
        /// <para> If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AddedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigShrinkRequestAddedCheck> AddedCheck { get; set; }
        public class ChangeCheckConfigShrinkRequestAddedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the ID of the check item.</para>
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
        /// <para>The requirement IDs that you want to specify for the check policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the requirement ID. If the ConfigStandardIds parameter is configured, this parameter does not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigRequirementIds")]
        [Validation(Required=false)]
        public string ConfigRequirementIdsShrink { get; set; }

        /// <summary>
        /// <para>The standard IDs that you want to specify for the check policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the standard ID.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigStandardIds")]
        [Validation(Required=false)]
        public string ConfigStandardIdsShrink { get; set; }

        /// <summary>
        /// <para>The configuration of the check item. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: Add all check items.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Configure")]
        [Validation(Required=false)]
        public string Configure { get; set; }

        /// <summary>
        /// <para>The days in a week on which a check is performed.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the new check items in the selected requirement item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic periodical check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// <para>The end time of the check. The value specifies a point in time in a day. The time period that is specified by the start time and end time must be one of the following time periods:</para>
        /// <list type="bullet">
        /// <item><description><b>00:00 to 06:00:</b> If you set the StartTime parameter to 0, you must set the EndTime parameter to 6.</description></item>
        /// <item><description><b>06:00 to 12:00</b>: If you set the StartTime parameter to 6, you must set the EndTime parameter to 12.</description></item>
        /// <item><description><b>12:00 to 18:00</b>: If you set the StartTime parameter to 12, you must set the EndTime parameter to 18.</description></item>
        /// <item><description><b>18:00 to 24:00:</b> If you set the StartTime parameter to 18, you must set the EndTime parameter to 24.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host to query.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of the check items that you want to remove from the policy.</para>
        /// <remarks>
        /// <para> If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemovedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigShrinkRequestRemovedCheck> RemovedCheck { get; set; }
        public class ChangeCheckConfigShrinkRequestRemovedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to obtain the ID of the check item.</para>
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
        /// <para>An array that consists of the information about the check item.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>The start time of the check. The value specifies a point in time in a day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the configuration automatically generated by the system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SystemConfig")]
        [Validation(Required=false)]
        public bool? SystemConfig { get; set; }

        /// <summary>
        /// <para>The cloud service providers.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
