// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetProjectResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FeatureEntityCount")]
        [Validation(Required=false)]
        public int? FeatureEntityCount { get; set; }

        [NameInMap("FeatureViewCount")]
        [Validation(Required=false)]
        public int? FeatureViewCount { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("ModelCount")]
        [Validation(Required=false)]
        public int? ModelCount { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OfflineDatasourceId")]
        [Validation(Required=false)]
        public string OfflineDatasourceId { get; set; }

        [NameInMap("OfflineDatasourceName")]
        [Validation(Required=false)]
        public string OfflineDatasourceName { get; set; }

        [NameInMap("OfflineDatasourceType")]
        [Validation(Required=false)]
        public string OfflineDatasourceType { get; set; }

        [NameInMap("OfflineLifecycle")]
        [Validation(Required=false)]
        public int? OfflineLifecycle { get; set; }

        [NameInMap("OnlineDatasourceId")]
        [Validation(Required=false)]
        public string OnlineDatasourceId { get; set; }

        [NameInMap("OnlineDatasourceName")]
        [Validation(Required=false)]
        public string OnlineDatasourceName { get; set; }

        [NameInMap("OnlineDatasourceType")]
        [Validation(Required=false)]
        public string OnlineDatasourceType { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
