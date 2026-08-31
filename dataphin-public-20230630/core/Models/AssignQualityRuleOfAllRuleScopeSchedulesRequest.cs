// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AssignQualityRuleOfAllRuleScopeSchedulesRequest : TeaModel {
        /// <summary>
        /// <para>The assignment binding command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AssignCommand")]
        [Validation(Required=false)]
        public AssignQualityRuleOfAllRuleScopeSchedulesRequestAssignCommand AssignCommand { get; set; }
        public class AssignQualityRuleOfAllRuleScopeSchedulesRequestAssignCommand : TeaModel {
            /// <summary>
            /// <para>The rule ID.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleIdList")]
            [Validation(Required=false)]
            public List<long?> RuleIdList { get; set; }

            /// <summary>
            /// <para>The schedule ID.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScheduleIdList")]
            [Validation(Required=false)]
            public List<long?> ScheduleIdList { get; set; }

            /// <summary>
            /// <para>The monitored object ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>平均值</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
