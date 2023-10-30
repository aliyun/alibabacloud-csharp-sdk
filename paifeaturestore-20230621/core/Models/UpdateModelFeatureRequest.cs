// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class UpdateModelFeatureRequest : TeaModel {
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<UpdateModelFeatureRequestFeatures> Features { get; set; }
        public class UpdateModelFeatureRequestFeatures : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        [NameInMap("SequenceFeatureViewIds")]
        [Validation(Required=false)]
        public List<string> SequenceFeatureViewIds { get; set; }

    }

}
