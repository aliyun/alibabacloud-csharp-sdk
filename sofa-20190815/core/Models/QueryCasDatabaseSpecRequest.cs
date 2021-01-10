// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseSpecRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("CustomStorage")]
        [Validation(Required=false)]
        public bool? CustomStorage { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("EnginesRepeatList")]
        [Validation(Required=false)]
        public List<string> EnginesRepeatList { get; set; }

        [NameInMap("EngineVersionsRepeatList")]
        [Validation(Required=false)]
        public List<string> EngineVersionsRepeatList { get; set; }

        [NameInMap("IaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IaasIdsRepeatList { get; set; }

        [NameInMap("IaasTypesRepeatList")]
        [Validation(Required=false)]
        public List<string> IaasTypesRepeatList { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("MaxCpu")]
        [Validation(Required=false)]
        public long? MaxCpu { get; set; }

        [NameInMap("MaxMaxConnections")]
        [Validation(Required=false)]
        public long? MaxMaxConnections { get; set; }

        [NameInMap("MaxMaxIops")]
        [Validation(Required=false)]
        public long? MaxMaxIops { get; set; }

        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public long? MaxMemory { get; set; }

        [NameInMap("MinCpu")]
        [Validation(Required=false)]
        public long? MinCpu { get; set; }

        [NameInMap("MinMaxConnections")]
        [Validation(Required=false)]
        public long? MinMaxConnections { get; set; }

        [NameInMap("MinMaxIops")]
        [Validation(Required=false)]
        public long? MinMaxIops { get; set; }

        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public long? MinMemory { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ProviderIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ProviderIdsRepeatList { get; set; }

        [NameInMap("TypesRepeatList")]
        [Validation(Required=false)]
        public List<string> TypesRepeatList { get; set; }

    }

}
