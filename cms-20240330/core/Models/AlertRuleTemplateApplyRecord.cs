// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTemplateApplyRecord : TeaModel {
        /// <summary>
        /// <para>The effective configuration for the rule application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;workspace&quot;:&quot;ws-1&quot;,&quot;displayName&quot;:&quot;CPU alert&quot;}</para>
        /// </summary>
        [NameInMap("applyConfig")]
        [Validation(Required=false)]
        public string ApplyConfig { get; set; }

        /// <summary>
        /// <para>The time when the record was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680861352600</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the record was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680861352600</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The UUID of the alert rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template-prometheus-ack-node-cpu-usage-exceeds-85</para>
        /// </summary>
        [NameInMap("templateUuid")]
        [Validation(Required=false)]
        public string TemplateUuid { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1654218965343050</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
