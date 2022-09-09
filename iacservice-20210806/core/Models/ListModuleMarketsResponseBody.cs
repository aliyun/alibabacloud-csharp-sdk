// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListModuleMarketsResponseBody : TeaModel {
        [NameInMap("moduleMarkets")]
        [Validation(Required=false)]
        public List<ListModuleMarketsResponseBodyModuleMarkets> ModuleMarkets { get; set; }
        public class ListModuleMarketsResponseBodyModuleMarkets : TeaModel {
            [NameInMap("cloneCount")]
            [Validation(Required=false)]
            public int? CloneCount { get; set; }

            [NameInMap("codeUrl")]
            [Validation(Required=false)]
            public string CodeUrl { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("moduleDetail")]
            [Validation(Required=false)]
            public string ModuleDetail { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleMarketId")]
            [Validation(Required=false)]
            public string ModuleMarketId { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relatedId")]
            [Validation(Required=false)]
            public long? RelatedId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
