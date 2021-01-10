// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricWebapidbconfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkefabricFabricWebapidbconfigsResponseBodyData Data { get; set; }
        public class QueryLinkefabricFabricWebapidbconfigsResponseBodyData : TeaModel {
            [NameInMap("DevStage")]
            [Validation(Required=false)]
            public string DevStage { get; set; }
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public string ExtraParams { get; set; }
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<string> Configs { get; set; }
            [NameInMap("ProjectConfigs")]
            [Validation(Required=false)]
            public List<string> ProjectConfigs { get; set; }
            [NameInMap("SameRepoAppList")]
            [Validation(Required=false)]
            public List<string> SameRepoAppList { get; set; }
        };

    }

}
