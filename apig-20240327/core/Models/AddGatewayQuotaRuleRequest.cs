// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The hash of the conflict snapshot, which is used to prevent concurrent dirty overwrites when you confirm to overwrite. You can obtain this value by performing a dry run with dryRun set to true and extracting it from the response.</para>
        /// <para>You do not need to specify this parameter in the following scenarios: no conflicts exist, you perform only a dry run with dryRun set to true, or you do not confirm to overwrite with overwrite set to false.</para>
        /// <para>If you set dryRun to false and overwrite to true but do not specify this parameter or the parameter expires and does not match, the backend returns accepted=false and a new conflict preview. In this case, you must perform a dry run again to confirm the new conflicts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <para>The IDs of the consumer groups to which the rule is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the consumers to which the rule is bound. You can specify up to 1,000 consumers at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002,1003</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without saving the configuration or delivering it to the gateway. A dry run checks whether conflicting rules exist on the bound subjects. A subject cannot have two natural period quotas with the same period. For example, if a subject already has a natural day quota, you cannot add another natural day quota rule to it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting when conflicts occur. If you allow overwriting, the conflicting subjects (consumers or consumer groups) are unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier in days. This parameter is required when windowAlignment is set to epoch. Valid values: 1 to 106751. Do not set this parameter for a natural period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. For a natural period, valid values are day, week, and month. For a custom period, only day is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The quota dimension or limit type. Valid values: token and credit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token</para>
        /// </summary>
        [NameInMap("quotaDimension")]
        [Validation(Required=false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// <para>The total available quota (limit) per period.</para>
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
        /// <para>The subject type of the rule. A value of consumer indicates a consumer, and a value of consumer_group indicates a consumer group. Default value: consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer_group</para>
        /// </summary>
        [NameInMap("subjectType")]
        [Validation(Required=false)]
        public string SubjectType { get; set; }

        /// <summary>
        /// <para>The time zone for the natural period, in UTC+x format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The reset period type. A value of calendar indicates a natural period, and a value of epoch indicates a custom period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("windowAlignment")]
        [Validation(Required=false)]
        public string WindowAlignment { get; set; }

    }

}
