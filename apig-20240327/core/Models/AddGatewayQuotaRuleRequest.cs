// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conflict snapshot hash, used to prevent concurrent dirty overwrites during confirmation. Retrieve this value from the response of a previous dry run (dryRun=true).</para>
        /// <para>This parameter is not required in the following cases: no conflicts exist, the request is a dry run (dryRun=true), or overwrite is set to false.</para>
        /// <para>When dryRun is set to false and overwrite is set to true, if this parameter is not provided or the value has expired and no longer matches, the backend returns accepted=false with a new conflict preview. Perform a new dry run to confirm the updated conflicts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <para>The list of consumer group IDs to bind to the rule. Specify this parameter when subjectType is set to consumer_group. This parameter cannot be specified together with consumerIds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <para>The list of consumer IDs to bind to the rule. A maximum of 1,000 consumers can be specified in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002,1003</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without applying the configuration. A dry run checks whether conflicting rules exist on the bound consumer subjects. For example, a consumer subject that already has a calendar-day quota cannot have another calendar-day quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting on conflict. If overwriting is allowed, the conflicting subjects (consumers or consumer groups) are unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier, which specifies the number of periods after which the quota resets. This parameter is required for custom period rules. Minimum value: 1. Maximum value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. For calendar periods, the value can be day, week, or month. For custom periods, only day is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The quota dimension or throttling type. Valid values: token and credit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token</para>
        /// </summary>
        [NameInMap("quotaDimension")]
        [Validation(Required=false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// <para>The total available quota per period.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("quotaLimit")]
        [Validation(Required=false)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-rule</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The subject type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>consumer: API consumer. This is the default value.</description></item>
        /// <item><description>consumer_group: API consumer group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>consumer_group</para>
        /// </summary>
        [NameInMap("subjectType")]
        [Validation(Required=false)]
        public string SubjectType { get; set; }

        /// <summary>
        /// <para>The time zone for the calendar period, in UTC+x format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The reset period type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>calendar: calendar period. The period starts from the beginning of a calendar day, week, or month.</description></item>
        /// <item><description>epoch: custom period. The period starts from the time the rule is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("windowAlignment")]
        [Validation(Required=false)]
        public string WindowAlignment { get; set; }

    }

}
