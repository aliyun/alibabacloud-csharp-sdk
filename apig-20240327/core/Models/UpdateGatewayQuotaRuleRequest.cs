// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of the subjects (consumers) to bind.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-001,cs-002</para>
        /// </summary>
        [NameInMap("addIds")]
        [Validation(Required=false)]
        public List<string> AddIds { get; set; }

        /// <summary>
        /// <para>The conflict snapshot hash, which is used to prevent concurrent dirty overwrites when confirming an overwrite. You can obtain this value by first executing a request with dryRun=true and extracting it from the response.</para>
        /// <para>You do not need to specify this parameter in the following scenarios: no conflicts exist; you are only performing a dry run with dryRun=true; or overwrite=false, meaning you do not confirm the overwrite.</para>
        /// <para>If dryRun=false and overwrite=true but this parameter is not provided or has expired and does not match, the backend returns accepted=false along with a new conflict preview. In this case, you must perform a dry run again to confirm the new conflicts.</para>
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
        /// <para><b>[Deprecated]</b> The list of consumer group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run only without saving to the database or delivering actual configurations. This is used to check whether conflicting rules exist on the bound consumers. A single consumer cannot be configured with two natural period quotas of the same period. For example, a consumer that already has a natural daily quota cannot be added with another natural daily quota rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow overwriting when a conflict occurs. Note that if overwriting is allowed, the conflicting subjects (consumers or consumer groups) will be unbound from the old rule and bound to the new rule.</para>
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
        /// <para>The list of IDs of the subjects (consumers) to unbind.</para>
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
