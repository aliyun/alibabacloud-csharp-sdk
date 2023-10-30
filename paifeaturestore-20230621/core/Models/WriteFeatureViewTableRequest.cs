// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class WriteFeatureViewTableRequest : TeaModel {
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        [NameInMap("UrlDatasource")]
        [Validation(Required=false)]
        public WriteFeatureViewTableRequestUrlDatasource UrlDatasource { get; set; }
        public class WriteFeatureViewTableRequestUrlDatasource : TeaModel {
            [NameInMap("Delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }

            [NameInMap("OmitHeader")]
            [Validation(Required=false)]
            public bool? OmitHeader { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

    }

}
