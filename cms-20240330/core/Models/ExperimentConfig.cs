// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ExperimentConfig : TeaModel {
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("modelParameters")]
        [Validation(Required=false)]
        public ModelParameters ModelParameters { get; set; }

        [NameInMap("modelProvider")]
        [Validation(Required=false)]
        public string ModelProvider { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("promptTemplate")]
        [Validation(Required=false)]
        public List<PromptTemplateItem> PromptTemplate { get; set; }

    }

}
