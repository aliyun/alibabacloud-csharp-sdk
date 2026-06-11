// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertEventIntegrationPolicyForModify : TeaModel {
        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test integration</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyName")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyName { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The filter settings.</para>
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
        /// <para>The transform settings.</para>
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

    }

}
