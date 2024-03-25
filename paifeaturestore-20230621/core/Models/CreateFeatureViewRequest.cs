// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateFeatureViewRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<CreateFeatureViewRequestFields> Fields { get; set; }
        public class CreateFeatureViewRequestFields : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RegisterDatasourceId")]
        [Validation(Required=false)]
        public string RegisterDatasourceId { get; set; }

        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        [NameInMap("SyncOnlineTable")]
        [Validation(Required=false)]
        public bool? SyncOnlineTable { get; set; }

        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("WriteMethod")]
        [Validation(Required=false)]
        public string WriteMethod { get; set; }

        [NameInMap("WriteToFeatureDB")]
        [Validation(Required=false)]
        public bool? WriteToFeatureDB { get; set; }

    }

}
