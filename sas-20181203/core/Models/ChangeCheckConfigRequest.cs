// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of check items to add to the policy.
        /// <notice> If ConfigStandardIds or ConfigRequirementIds is specified, this parameter does not take effect.</para>
        /// </summary>
        [NameInMap("AddedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestAddedCheck> AddedCheck { get; set; }
        public class ChangeCheckConfigRequestAddedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para>Call <a href="~~ListCheckResult~~">ListCheckResult</a> to obtain check item IDs.</para>
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
        /// <para>The client token used to ensure request idempotency. Use a different token for each request. Only ASCII characters are supported. The token can be up to 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Configures the check policy by specifying requirement IDs.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListCheckResult~~">ListCheckResult</a> to obtain requirement IDs. If ConfigStandardIds is specified, this parameter does not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigRequirementIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigRequirementIds ConfigRequirementIds { get; set; }
        public class ChangeCheckConfigRequestConfigRequirementIds : TeaModel {
            /// <summary>
            /// <para>The list of requirement IDs to add to the policy.</para>
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// <para>The list of requirement IDs to remove from the policy.</para>
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// <para>Configures the check policy by specifying standard IDs.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListCheckResult~~">ListCheckResult</a> to obtain standard IDs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigStandardIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigStandardIds ConfigStandardIds { get; set; }
        public class ChangeCheckConfigRequestConfigStandardIds : TeaModel {
            /// <summary>
            /// <para>The list of standard IDs to add to the policy.</para>
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// <para>The list of standard IDs to remove from the policy.</para>
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// <para>The field configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all:</b> Adds all check items.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Configure")]
        [Validation(Required=false)]
        public string Configure { get; set; }

        /// <summary>
        /// <para>The scheduled check days.</para>
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically include newly added check items from the selected requirements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> Enabled.</description></item>
        /// <item><description><b>false:</b> Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic scheduled checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> Enabled.</description></item>
        /// <item><description><b>false:</b> Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// <para>The end hour of the check time window, expressed as an hour of the day. The start and end times must fall within one of the following time ranges. Valid values: 6, 12, 18, 24.</para>
        /// <list type="bullet">
        /// <item><description><b>0~6:</b> If the start time is 0, set the end time to 6.</description></item>
        /// <item><description><b>6~12:</b> If the start time is 6, set the end time to 12.</description></item>
        /// <item><description><b>12~18:</b> If the start time is 12, set the end time to 18.</description></item>
        /// <item><description><b>18~24:</b> If the start time is 18, set the end time to 24.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The region of the Security Center instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> China (Hangzhou)</description></item>
        /// <item><description><b>ap-southeast-1:</b> Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of check items to remove from the policy.
        /// <notice> If ConfigStandardIds or ConfigRequirementIds is specified, this parameter does not take effect.</para>
        /// </summary>
        [NameInMap("RemovedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestRemovedCheck> RemovedCheck { get; set; }
        public class ChangeCheckConfigRequestRemovedCheck : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// <remarks>
            /// <para>Call <a href="~~ListCheckResult~~">ListCheckResult</a> to obtain check item IDs.</para>
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
        /// <para>The ID of the resource directory member accounts (Alibaba Cloud account).</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. You do not need to configure it.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>The start hour of the check time window, expressed as an hour of the day. The start and end times must fall within one of the following time ranges. Valid values: 0, 6, 12, 18.</para>
        /// <list type="bullet">
        /// <item><description><b>0~6:</b> If the start time is 0, set the end time to 6.</description></item>
        /// <item><description><b>6~12:</b> If the start time is 6, set the end time to 12.</description></item>
        /// <item><description><b>12~18:</b> If the start time is 12, set the end time to 18.</description></item>
        /// <item><description><b>18~24:</b> If the start time is 18, set the end time to 24.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the system-generated configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> Yes.</description></item>
        /// <item><description><b>false:</b> No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SystemConfig")]
        [Validation(Required=false)]
        public bool? SystemConfig { get; set; }

        /// <summary>
        /// <para>The list of cloud vendors.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
