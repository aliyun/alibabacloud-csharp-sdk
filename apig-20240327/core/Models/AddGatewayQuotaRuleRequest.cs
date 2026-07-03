// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conflict snapshot hash used to prevent concurrent dirty overwrites during confirmation. Obtain this value from the response of a previous dryRun=true call.</para>
        /// <para>You do not need to specify this parameter in the following cases: no conflict exists, the request is a dry run (dryRun=true), or overwrite=false.</para>
        /// <para>When dryRun=false and overwrite=true, if this parameter is not specified or the value has expired, the backend returns accepted=false with a new conflict preview. Perform a dry run again to confirm the new conflict.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The list of consumer group IDs. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <para>The list of consumer IDs to bind to the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001,1002,1003</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without persisting or applying the configuration. A dry run checks whether conflicting rules exist on the bound consumers. For example, a consumer that already has a daily calendar quota cannot have another daily calendar quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting on conflict. If overwriting is allowed, the conflicting principals (consumers) are unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. Valid values: day (calendar day), week (calendar week), and month (calendar month).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The quota dimension or throttling type. Currently, only token is supported.</para>
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
        /// <para>团队规则</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

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
        /// <para>The reset period alignment type. Currently, only calendar alignment is supported, which means windowAlignment=&quot;calendar&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("windowAlignment")]
        [Validation(Required=false)]
        public string WindowAlignment { get; set; }

    }

}
