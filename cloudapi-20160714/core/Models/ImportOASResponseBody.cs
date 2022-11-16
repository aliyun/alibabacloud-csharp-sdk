// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASResponseBody : TeaModel {
        [NameInMap("ErrorMessages")]
        [Validation(Required=false)]
        public ImportOASResponseBodyErrorMessages ErrorMessages { get; set; }
        public class ImportOASResponseBodyErrorMessages : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public List<string> ErrorMessage { get; set; }

        }

        [NameInMap("FailedApis")]
        [Validation(Required=false)]
        public ImportOASResponseBodyFailedApis FailedApis { get; set; }
        public class ImportOASResponseBodyFailedApis : TeaModel {
            [NameInMap("FailedApi")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodyFailedApisFailedApi> FailedApi { get; set; }
            public class ImportOASResponseBodyFailedApisFailedApi : TeaModel {
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        [NameInMap("FailedModels")]
        [Validation(Required=false)]
        public ImportOASResponseBodyFailedModels FailedModels { get; set; }
        public class ImportOASResponseBodyFailedModels : TeaModel {
            [NameInMap("FailedModel")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodyFailedModelsFailedModel> FailedModel { get; set; }
            public class ImportOASResponseBodyFailedModelsFailedModel : TeaModel {
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

        }

        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessApis")]
        [Validation(Required=false)]
        public ImportOASResponseBodySuccessApis SuccessApis { get; set; }
        public class ImportOASResponseBodySuccessApis : TeaModel {
            [NameInMap("SuccessApi")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodySuccessApisSuccessApi> SuccessApi { get; set; }
            public class ImportOASResponseBodySuccessApisSuccessApi : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        [NameInMap("SuccessModels")]
        [Validation(Required=false)]
        public ImportOASResponseBodySuccessModels SuccessModels { get; set; }
        public class ImportOASResponseBodySuccessModels : TeaModel {
            [NameInMap("SuccessModel")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodySuccessModelsSuccessModel> SuccessModel { get; set; }
            public class ImportOASResponseBodySuccessModelsSuccessModel : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("ModelOperation")]
                [Validation(Required=false)]
                public string ModelOperation { get; set; }

                [NameInMap("ModelUid")]
                [Validation(Required=false)]
                public string ModelUid { get; set; }

            }

        }

        [NameInMap("WarningMessages")]
        [Validation(Required=false)]
        public ImportOASResponseBodyWarningMessages WarningMessages { get; set; }
        public class ImportOASResponseBodyWarningMessages : TeaModel {
            [NameInMap("WarningMessage")]
            [Validation(Required=false)]
            public List<string> WarningMessage { get; set; }

        }

    }

}
