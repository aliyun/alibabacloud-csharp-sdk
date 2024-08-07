// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetProjectFeatureViewResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        [NameInMap("FeatureEntityName")]
        [Validation(Required=false)]
        public string FeatureEntityName { get; set; }

        [NameInMap("FeatureViewId")]
        [Validation(Required=false)]
        public string FeatureViewId { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetProjectFeatureViewResponseBodyFields> Fields { get; set; }
        public class GetProjectFeatureViewResponseBodyFields : TeaModel {
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

        [NameInMap("GmtSyncTime")]
        [Validation(Required=false)]
        public string GmtSyncTime { get; set; }

        [NameInMap("JoinId")]
        [Validation(Required=false)]
        public string JoinId { get; set; }

        [NameInMap("LastSyncConfig")]
        [Validation(Required=false)]
        public string LastSyncConfig { get; set; }

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

        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

    }

}
