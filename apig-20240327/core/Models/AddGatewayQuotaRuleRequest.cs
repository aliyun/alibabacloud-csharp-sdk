// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conflict snapshot hash, used to prevent concurrent dirty overwrites during confirmation. Obtain this value from the response of a previous dryRun=true request.</para>
        /// <para>This parameter is not required in the following cases: no conflicts exist, the request is a dry run (dryRun=true), or overwrite=false (no overwrite confirmation).</para>
        /// <para>When dryRun=false and overwrite=true, if this parameter is not provided or the value has expired and no longer matches, the backend returns accepted=false with a new conflict preview. Perform a dry run again to confirm the new conflicts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <para>The list of consumer group IDs (not supported currently).</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <para>The list of consumer IDs to bind to the rule. A maximum of 1000 consumers can be specified in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002,1003</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without applying the configuration. A dry run checks whether conflicting rules exist on the bound consumers. For example, a consumer that already has a calendar-day quota cannot have another calendar-day quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting when conflicts exist. If overwriting is allowed, the conflicting subjects (consumers) are unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier. This parameter applies to epoch period rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. For calendar periods, statistics are collected by day, week, or month. Valid values: day, week, and month. For epoch periods, only day is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The quota dimension or throttling type. Valid values: token and credit. The credit quota applies only to dedicated instances running version 2.1.19 or later.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token</para>
        /// </summary>
        [NameInMap("quotaDimension")]
        [Validation(Required=false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// <para>The total available quota per period (limit).</para>
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
        /// <para>The rule subject type. Valid values: consumer (a consumer) and consumer_group (a consumer group). Default value: consumer.</para>
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
        /// <para>The reset period type. Valid values: calendar (the period starts from the beginning of a calendar day, week, or month) and epoch (the period starts from when the rule is applied). The epoch type applies only to dedicated instances running version 2.1.19 or later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("windowAlignment")]
        [Validation(Required=false)]
        public string WindowAlignment { get; set; }

    }

}
