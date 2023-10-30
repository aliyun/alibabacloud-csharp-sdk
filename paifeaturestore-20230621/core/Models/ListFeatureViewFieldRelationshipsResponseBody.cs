// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewFieldRelationshipsResponseBody : TeaModel {
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewFieldRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewFieldRelationshipsResponseBodyRelationships : TeaModel {
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewFieldRelationshipsResponseBodyRelationshipsModels : TeaModel {
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            [NameInMap("OfflineTableName")]
            [Validation(Required=false)]
            public string OfflineTableName { get; set; }

            [NameInMap("OnlineTableName")]
            [Validation(Required=false)]
            public string OnlineTableName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
