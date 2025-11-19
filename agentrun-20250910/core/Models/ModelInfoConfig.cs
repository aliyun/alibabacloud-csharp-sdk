// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelInfoConfig : TeaModel {
        [NameInMap("modelFeatures")]
        [Validation(Required=false)]
        public ModelFeatures ModelFeatures { get; set; }

        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("modelParameterRules")]
        [Validation(Required=false)]
        public List<ModelParameterRule> ModelParameterRules { get; set; }

        [NameInMap("modelProperties")]
        [Validation(Required=false)]
        public ModelProperties ModelProperties { get; set; }

    }

}
