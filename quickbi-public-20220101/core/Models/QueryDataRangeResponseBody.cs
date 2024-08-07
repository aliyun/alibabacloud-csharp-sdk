// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRangeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataRangeResponseBodyResult Result { get; set; }
        public class QueryDataRangeResponseBodyResult : TeaModel {
            [NameInMap("ApiCopilotLlmCubeModels")]
            [Validation(Required=false)]
            public List<QueryDataRangeResponseBodyResultApiCopilotLlmCubeModels> ApiCopilotLlmCubeModels { get; set; }
            public class QueryDataRangeResponseBodyResultApiCopilotLlmCubeModels : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("LlmCubeId")]
                [Validation(Required=false)]
                public string LlmCubeId { get; set; }

            }

            [NameInMap("ApiCopilotThemeModels")]
            [Validation(Required=false)]
            public List<QueryDataRangeResponseBodyResultApiCopilotThemeModels> ApiCopilotThemeModels { get; set; }
            public class QueryDataRangeResponseBodyResultApiCopilotThemeModels : TeaModel {
                [NameInMap("ApiCopilotLlmCubeModels")]
                [Validation(Required=false)]
                public List<QueryDataRangeResponseBodyResultApiCopilotThemeModelsApiCopilotLlmCubeModels> ApiCopilotLlmCubeModels { get; set; }
                public class QueryDataRangeResponseBodyResultApiCopilotThemeModelsApiCopilotLlmCubeModels : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    [NameInMap("LlmCubeId")]
                    [Validation(Required=false)]
                    public string LlmCubeId { get; set; }

                }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public string ThemeId { get; set; }

                [NameInMap("ThemeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
