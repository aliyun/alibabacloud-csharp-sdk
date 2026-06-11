// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertEventIntegrationPolicyForView : TeaModel {
        /// <summary>
        /// <para>The universally unique identifier (UUID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyId")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>集成名</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyName")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyName { get; set; }

        /// <summary>
        /// <para>The time when the policy was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The filter configuration.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>The subscription settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("integrationSetting")]
        [Validation(Required=false)]
        public string IntegrationSetting { get; set; }

        /// <summary>
        /// <para>The key for the integration\&quot;s reporting endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10-16818f1445e10a1d012922b285bfb334</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The transformation settings.</para>
        /// </summary>
        [NameInMap("transformerSetting")]
        [Validation(Required=false)]
        public List<TransformAction> TransformerSetting { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT_CUSTOM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the policy was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-16T02:00:23Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
