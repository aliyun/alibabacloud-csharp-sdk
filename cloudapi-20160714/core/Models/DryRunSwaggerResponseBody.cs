// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DryRunSwaggerResponseBody : TeaModel {
        /// <summary>
        /// The APIs that failed to be created based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("Failed")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyFailed Failed { get; set; }
        public class DryRunSwaggerResponseBodyFailed : TeaModel {
            [NameInMap("ApiImportSwaggerFailed")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyFailedApiImportSwaggerFailed> ApiImportSwaggerFailed { get; set; }
            public class DryRunSwaggerResponseBodyFailedApiImportSwaggerFailed : TeaModel {
                /// <summary>
                /// The error message returned when the API is created.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The HTTP method configured when the API is created.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path configured when the API is created.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// The global condition.
        /// </summary>
        [NameInMap("GlobalCondition")]
        [Validation(Required=false)]
        public string GlobalCondition { get; set; }

        /// <summary>
        /// The models that failed to be imported through the Swagger-compliant data this time.
        /// </summary>
        [NameInMap("ModelFailed")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyModelFailed ModelFailed { get; set; }
        public class DryRunSwaggerResponseBodyModelFailed : TeaModel {
            [NameInMap("ApiImportModelFailed")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyModelFailedApiImportModelFailed> ApiImportModelFailed { get; set; }
            public class DryRunSwaggerResponseBodyModelFailedApiImportModelFailed : TeaModel {
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
        /// The models that failed to be imported through the Swagger-compliant data this time.
        /// </summary>
        [NameInMap("ModelSuccess")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyModelSuccess ModelSuccess { get; set; }
        public class DryRunSwaggerResponseBodyModelSuccess : TeaModel {
            [NameInMap("ApiImportModelSuccess")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyModelSuccessApiImportModelSuccess> ApiImportModelSuccess { get; set; }
            public class DryRunSwaggerResponseBodyModelSuccessApiImportModelSuccess : TeaModel {
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
        /// The APIs that are created based on the Swagger-compliant data imported this time.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodySuccess Success { get; set; }
        public class DryRunSwaggerResponseBodySuccess : TeaModel {
            [NameInMap("ApiDryRunSwaggerSuccess")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodySuccessApiDryRunSwaggerSuccess> ApiDryRunSwaggerSuccess { get; set; }
            public class DryRunSwaggerResponseBodySuccessApiDryRunSwaggerSuccess : TeaModel {
                /// <summary>
                /// Specifies whether the operation is CREATE or MODIFY.
                /// </summary>
                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                /// <summary>
                /// The API definition that complies with the Swagger specification.
                /// </summary>
                [NameInMap("ApiSwagger")]
                [Validation(Required=false)]
                public string ApiSwagger { get; set; }

                /// <summary>
                /// The UID of the successfully imported API.
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// The HTTP method configured when the API is created.
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request path configured when the API is created.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

    }

}
