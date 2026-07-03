// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ResetGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conflict snapshot hash, used to prevent concurrent dirty overwrites during confirmation. Obtain this value from the response data of a previous dryRun=true call.</para>
        /// <para>This parameter is not required in the following cases: no conflict exists, the request is a dry run (dryRun=true), or overwrite=false (overwrite not confirmed).</para>
        /// <para>When dryRun=false and overwrite=true, if this parameter is not provided or the value has expired and no longer matches, the backend returns accepted=false with a new conflict preview. You must perform a dry run again to confirm the new conflict.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without delivering the actual configuration. A dry run checks whether conflicting rules exist on the bound consumers. For example, a consumer that already has a calendar-day quota cannot have another calendar-day quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting on conflict. If overwriting is allowed, the conflicting entity (consumer) is unbound from the old rule and bound to the new rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The period multiplier, indicating how many periods elapse before the quota resets. Returned when the rule uses a custom period. Minimum value: 1. Maximum value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("periodMultiplier")]
        [Validation(Required=false)]
        public long? PeriodMultiplier { get; set; }

        /// <summary>
        /// <para>The period type. Valid values: day, week, or month.</para>
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
        /// <para>The time zone corresponding to the calendar period (UTC+x format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC+8</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The period type after the reset. Currently only calendar periods are supported, which means windowAlignment=&quot;calendar&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("windowAlignment")]
        [Validation(Required=false)]
        public string WindowAlignment { get; set; }

    }

}
