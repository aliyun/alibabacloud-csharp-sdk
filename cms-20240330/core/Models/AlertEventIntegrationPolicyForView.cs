// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertEventIntegrationPolicyForView : TeaModel {
        /// <summary>
        /// <para>UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyId")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyName")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("integrationSetting")]
        [Validation(Required=false)]
        public string IntegrationSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10-16818f1445e10a1d012922b285bfb334</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("transformerSetting")]
        [Validation(Required=false)]
        public List<TransformAction> TransformerSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALERT_CUSTOM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-12-16T02:00:23Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
