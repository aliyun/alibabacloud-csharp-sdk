// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASResponseBody : TeaModel {
        /// <summary>
        /// The error messages that appear due to the invalid data in the imported file.
        /// </summary>
        [NameInMap("ErrorMessages")]
        [Validation(Required=false)]
        public ImportOASResponseBodyErrorMessages ErrorMessages { get; set; }
        public class ImportOASResponseBodyErrorMessages : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public List<string> ErrorMessage { get; set; }

        }

        /// <summary>
        /// The APIs that failed to pass the precheck.
        /// </summary>
        [NameInMap("FailedApis")]
        [Validation(Required=false)]
        public ImportOASResponseBodyFailedApis FailedApis { get; set; }
        public class ImportOASResponseBodyFailedApis : TeaModel {
            [NameInMap("FailedApi")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodyFailedApisFailedApi> FailedApi { get; set; }
            public class ImportOASResponseBodyFailedApisFailedApi : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The HTTP method configured when you created the API.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path configured when you created the API.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// The information about the models that failed to pass the precheck.
        /// </summary>
        [NameInMap("FailedModels")]
        [Validation(Required=false)]
        public ImportOASResponseBodyFailedModels FailedModels { get; set; }
        public class ImportOASResponseBodyFailedModels : TeaModel {
            [NameInMap("FailedModel")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodyFailedModelsFailedModel> FailedModel { get; set; }
            public class ImportOASResponseBodyFailedModelsFailedModel : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the model.
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the asynchronous API import task that was generated during the import operation. This ID is used to query the execution status of the API import task.
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the APIs that have passed the precheck.
        /// </summary>
        [NameInMap("SuccessApis")]
        [Validation(Required=false)]
        public ImportOASResponseBodySuccessApis SuccessApis { get; set; }
        public class ImportOASResponseBodySuccessApis : TeaModel {
            [NameInMap("SuccessApi")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodySuccessApisSuccessApi> SuccessApi { get; set; }
            public class ImportOASResponseBodySuccessApisSuccessApi : TeaModel {
                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// Indicates that the operation is CREATE or MODIFY.
                /// </summary>
                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                /// <summary>
                /// The HTTP method configured when you created the API.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path configured when you created the API.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// The information about the models that have passed the precheck.
        /// </summary>
        [NameInMap("SuccessModels")]
        [Validation(Required=false)]
        public ImportOASResponseBodySuccessModels SuccessModels { get; set; }
        public class ImportOASResponseBodySuccessModels : TeaModel {
            [NameInMap("SuccessModel")]
            [Validation(Required=false)]
            public List<ImportOASResponseBodySuccessModelsSuccessModel> SuccessModel { get; set; }
            public class ImportOASResponseBodySuccessModelsSuccessModel : TeaModel {
                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the model.
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// The operation of the model. Valid values: CREATE and MODIFY.
                /// </summary>
                [NameInMap("ModelOperation")]
                [Validation(Required=false)]
                public string ModelOperation { get; set; }

                /// <summary>
                /// The UID of the model.
                /// </summary>
                [NameInMap("ModelUid")]
                [Validation(Required=false)]
                public string ModelUid { get; set; }

            }

        }

        /// <summary>
        /// The warning messages that appear due to the invalid data in the imported file.
        /// </summary>
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
