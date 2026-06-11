// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cs-001,cs-002</para>
        /// </summary>
        [NameInMap("addIds")]
        [Validation(Required=false)]
        public List<string> AddIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541f50xxxxxx</para>
        /// </summary>
        [NameInMap("conflictHash")]
        [Validation(Required=false)]
        public string ConflictHash { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>group1,group2</para>
        /// </summary>
        [NameInMap("consumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("quotaLimit")]
        [Validation(Required=false)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cs003,cs-004</para>
        /// </summary>
        [NameInMap("removeIds")]
        [Validation(Required=false)]
        public List<string> RemoveIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-rule</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
