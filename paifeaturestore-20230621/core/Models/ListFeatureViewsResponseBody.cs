// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewsResponseBody : TeaModel {
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListFeatureViewsResponseBodyFeatureViews : TeaModel {
            [NameInMap("FeatureEntityName")]
            [Validation(Required=false)]
            public string FeatureEntityName { get; set; }

            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("RegisterDatasourceId")]
            [Validation(Required=false)]
            public string RegisterDatasourceId { get; set; }

            [NameInMap("RegisterDatasourceName")]
            [Validation(Required=false)]
            public string RegisterDatasourceName { get; set; }

            [NameInMap("RegisterTable")]
            [Validation(Required=false)]
            public string RegisterTable { get; set; }

            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
