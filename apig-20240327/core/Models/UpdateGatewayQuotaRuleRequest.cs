// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of principal (consumer) IDs to bind.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-001,cs-002</para>
        /// </summary>
        [NameInMap("addIds")]
        [Validation(Required=false)]
        public List<string> AddIds { get; set; }

        /// <summary>
        /// <para>The conflict snapshot hash, used to prevent concurrent dirty overwrites when confirming an overwrite. Obtain this value from the response of a prior dryRun=true call.</para>
        /// <para>This parameter is not required in the following cases: no conflicts exist, the call is a dry run (dryRun=true), or overwrite is set to false.</para>
        /// <para>When dryRun is set to false and overwrite is set to true, if this parameter is missing or the value has expired and no longer matches, the backend returns accepted=false with a new conflict preview. Perform the dry run again to confirm the new conflicts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541f50xxxxxx</para>
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
        /// <para>Specifies whether to perform a dry run only without persisting or applying the configuration. A dry run checks whether conflicting rules exist on the bound consumers. For example, a consumer that already has a calendar-day quota cannot have another calendar-day quota rule added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting when a conflict exists. If overwriting is allowed, the conflicting principals (consumers) are unbound from the old rule and bound to the new rule.</para>
        /// </summary>
        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The updated total available quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("quotaLimit")]
        [Validation(Required=false)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// <para>The list of principal (consumer) IDs to unbind.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs003,cs-004</para>
        /// </summary>
        [NameInMap("removeIds")]
        [Validation(Required=false)]
        public List<string> RemoveIds { get; set; }

        /// <summary>
        /// <para>The updated rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-rule</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
