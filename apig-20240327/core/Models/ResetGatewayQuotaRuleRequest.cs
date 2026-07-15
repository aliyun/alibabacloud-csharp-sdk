// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ResetGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conflict snapshot hash, used to prevent concurrent dirty overwrites during a confirmed overwrite. Obtain this value from the response of a previous dry run (dryRun=true).</para>
        /// <para>You do not need to specify this parameter in the following cases: no conflicts exist, you are performing a dry run (dryRun=true), or you set overwrite to false.</para>
        /// <para>If dryRun is set to false and overwrite is set to true but this parameter is not specified or the value has expired, the backend returns accepted=false with a new conflict preview. You must perform a new dry run to confirm the updated conflicts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without persisting or applying the configuration. A dry run checks whether conflicting rules exist on the bound consumers. For example, a consumer that already has a calendar-day quota cannot have another calendar-day quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting when conflicts exist. If overwriting is allowed, the conflicting entity (consumer) is unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier, which specifies the number of periods after which the quota is reset. This parameter is returned when the rule uses a custom period. Minimum value: 1. Maximum value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. Calendar periods support daily, weekly, and monthly statistics. Valid values: day, week, and month. Custom periods support only daily statistics. The value is fixed to day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>week</para>
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The total available quota per period after the reset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("quotaLimit")]
        [Validation(Required=false)]
        public long? QuotaLimit { get; set; }

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
        /// <para>The period alignment type after the reset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>calendar: calendar period.</description></item>
        /// <item><description>epoch: custom period. Custom periods are supported only on dedicated instances running version 2.1.19 or later.</description></item>
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
