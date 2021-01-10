// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseSpecResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasDatabaseSpecResponseBodyData> Data { get; set; }
        public class QueryCasDatabaseSpecResponseBodyData : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            [NameInMap("CustomStorage")]
            [Validation(Required=false)]
            public bool? CustomStorage { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("IaasId")]
            [Validation(Required=false)]
            public string IaasId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public long? MaxConnections { get; set; }

            [NameInMap("MaxIops")]
            [Validation(Required=false)]
            public long? MaxIops { get; set; }

            [NameInMap("MaxStorage")]
            [Validation(Required=false)]
            public long? MaxStorage { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("MinStorage")]
            [Validation(Required=false)]
            public long? MinStorage { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public List<string> EngineVersion { get; set; }

            [NameInMap("SupportedStorages")]
            [Validation(Required=false)]
            public List<string> SupportedStorages { get; set; }

        }

    }

}
