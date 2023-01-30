// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportSwaggerResponseBody : TeaModel {
        /// <summary>
        /// The APIs that failed to be created based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("Failed")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyFailed Failed { get; set; }
        public class ImportSwaggerResponseBodyFailed : TeaModel {
            [NameInMap("ApiImportSwaggerFailed")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyFailedApiImportSwaggerFailed> ApiImportSwaggerFailed { get; set; }
            public class ImportSwaggerResponseBodyFailedApiImportSwaggerFailed : TeaModel {
                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The HTTP method of the API.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path of the API.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// The models that failed to be imported based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("ModelFailed")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyModelFailed ModelFailed { get; set; }
        public class ImportSwaggerResponseBodyModelFailed : TeaModel {
            [NameInMap("ApiImportModelFailed")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyModelFailedApiImportModelFailed> ApiImportModelFailed { get; set; }
            public class ImportSwaggerResponseBodyModelFailedApiImportModelFailed : TeaModel {
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
        /// The models that were imported based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("ModelSuccess")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyModelSuccess ModelSuccess { get; set; }
        public class ImportSwaggerResponseBodyModelSuccess : TeaModel {
            [NameInMap("ApiImportModelSuccess")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyModelSuccessApiImportModelSuccess> ApiImportModelSuccess { get; set; }
            public class ImportSwaggerResponseBodyModelSuccessApiImportModelSuccess : TeaModel {
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
                /// The model operation.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The APIs that were created based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodySuccess Success { get; set; }
        public class ImportSwaggerResponseBodySuccess : TeaModel {
            [NameInMap("ApiImportSwaggerSuccess")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodySuccessApiImportSwaggerSuccess> ApiImportSwaggerSuccess { get; set; }
            public class ImportSwaggerResponseBodySuccessApiImportSwaggerSuccess : TeaModel {
                /// <summary>
                /// Specifies that the operation is CREATE or MODIFY.
                /// </summary>
                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                /// <summary>
                /// The UID of the imported API.
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// The HTTP method of the API.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path of the API.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

    }

}
