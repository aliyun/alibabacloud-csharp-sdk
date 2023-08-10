// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class App : TeaModel {
        [NameInMap("autoSwitch")]
        [Validation(Required=false)]
        public bool? AutoSwitch { get; set; }

        [NameInMap("cluster")]
        [Validation(Required=false)]
        public AppCluster Cluster { get; set; }
        public class AppCluster : TeaModel {
            [NameInMap("maxQueryClauseLength")]
            [Validation(Required=false)]
            public int? MaxQueryClauseLength { get; set; }

            [NameInMap("maxTimeoutMS")]
            [Validation(Required=false)]
            public int? MaxTimeoutMS { get; set; }

        }

        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<DataSource> DataSources { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public Domain Domain { get; set; }

        [NameInMap("fetchFields")]
        [Validation(Required=false)]
        public List<string> FetchFields { get; set; }

        [NameInMap("firstRanks")]
        [Validation(Required=false)]
        public List<FirstRank> FirstRanks { get; set; }

        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("queryProcessors")]
        [Validation(Required=false)]
        public List<QueryProcessor> QueryProcessors { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public Quota Quota { get; set; }

        [NameInMap("realtimeShared")]
        [Validation(Required=false)]
        public bool? RealtimeShared { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

        [NameInMap("schemas")]
        [Validation(Required=false)]
        public List<Schema> Schemas { get; set; }

        [NameInMap("secondRanks")]
        [Validation(Required=false)]
        public List<SecondRank> SecondRanks { get; set; }

        [NameInMap("summaries")]
        [Validation(Required=false)]
        public List<Summary> Summaries { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
