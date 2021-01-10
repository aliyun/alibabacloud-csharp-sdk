// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseRequest : TeaModel {
        [NameInMap("AppIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppIdsRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServiceIdsRepeatList { get; set; }

        [NameInMap("ConnectionAddressesRepeatList")]
        [Validation(Required=false)]
        public List<string> ConnectionAddressesRepeatList { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("EnginesRepeatList")]
        [Validation(Required=false)]
        public List<string> EnginesRepeatList { get; set; }

        [NameInMap("EngineVersionsRepeatList")]
        [Validation(Required=false)]
        public List<string> EngineVersionsRepeatList { get; set; }

        [NameInMap("IncludeShared")]
        [Validation(Required=false)]
        public bool? IncludeShared { get; set; }

        [NameInMap("MasterIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> MasterIdsRepeatList { get; set; }

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

        [NameInMap("MaxPort")]
        [Validation(Required=false)]
        public long? MaxPort { get; set; }

        [NameInMap("MaxStorage")]
        [Validation(Required=false)]
        public long? MaxStorage { get; set; }

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

        [NameInMap("MinPort")]
        [Validation(Required=false)]
        public long? MinPort { get; set; }

        [NameInMap("MinStorage")]
        [Validation(Required=false)]
        public long? MinStorage { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SpecIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> SpecIaasIdsRepeatList { get; set; }

        [NameInMap("StatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> StatusesRepeatList { get; set; }

        [NameInMap("TypesRepeatList")]
        [Validation(Required=false)]
        public List<string> TypesRepeatList { get; set; }

        [NameInMap("VpcIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> VpcIdsRepeatList { get; set; }

        [NameInMap("VSwitchIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> VSwitchIaasIdsRepeatList { get; set; }

        [NameInMap("WorkspaceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkspaceIdsRepeatList { get; set; }

    }

}
