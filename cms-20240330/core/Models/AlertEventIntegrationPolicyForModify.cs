// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertEventIntegrationPolicyForModify : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("alertEventIntegrationPolicyName")]
        [Validation(Required=false)]
        public string AlertEventIntegrationPolicyName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        [NameInMap("integrationSetting")]
        [Validation(Required=false)]
        public string IntegrationSetting { get; set; }

        [NameInMap("transformerSetting")]
        [Validation(Required=false)]
        public List<TransformAction> TransformerSetting { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
