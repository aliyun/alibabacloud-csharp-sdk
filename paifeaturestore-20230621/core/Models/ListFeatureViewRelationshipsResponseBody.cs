// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewRelationshipsResponseBody : TeaModel {
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewRelationshipsResponseBodyRelationships : TeaModel {
            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewRelationshipsResponseBodyRelationshipsModels : TeaModel {
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
