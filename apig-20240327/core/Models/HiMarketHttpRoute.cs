// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHttpRoute : TeaModel {
        [NameInMap("builtin")]
        [Validation(Required=false)]
        public bool? Builtin { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<HiMarketDomain> Domains { get; set; }

        [NameInMap("match")]
        [Validation(Required=false)]
        public HiMarketHttpRouteMatch Match { get; set; }
        public class HiMarketHttpRouteMatch : TeaModel {
            [NameInMap("headers")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchHeaders> Headers { get; set; }
            public class HiMarketHttpRouteMatchHeaders : TeaModel {
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("methods")]
            [Validation(Required=false)]
            public List<string> Methods { get; set; }

            [NameInMap("modelMatches")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchModelMatches> ModelMatches { get; set; }
            public class HiMarketHttpRouteMatchModelMatches : TeaModel {
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("path")]
            [Validation(Required=false)]
            public HiMarketHttpRouteMatchPath Path { get; set; }
            public class HiMarketHttpRouteMatchPath : TeaModel {
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("queryParams")]
            [Validation(Required=false)]
            public List<HiMarketHttpRouteMatchQueryParams> QueryParams { get; set; }
            public class HiMarketHttpRouteMatchQueryParams : TeaModel {
                [NameInMap("caseSensitive")]
                [Validation(Required=false)]
                public bool? CaseSensitive { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
