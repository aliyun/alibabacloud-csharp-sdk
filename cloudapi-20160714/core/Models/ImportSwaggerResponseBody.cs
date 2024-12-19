// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportSwaggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The APIs that failed to be created based on the Swagger-compliant data imported this time.</para>
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
                /// <para>The error message returned when the API is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api already exists : apiUid ===&gt; 8e274ec61cf6468e83b68371956831cb</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The HTTP method configured when the API is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>post</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The request path configured when the API is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/http/get/mapping</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The models that failed to be imported through the Swagger-compliant data this time.</para>
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
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error msg</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36d4bcfaec1946e1870d90b2d7519710</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Region</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

        }

        /// <summary>
        /// <para>The models that were imported through the Swagger-compliant data this time.</para>
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
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b2d552ed90ca435b86f7bf8d45414793</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NewInstance</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model operation</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE</para>
                /// </summary>
                [NameInMap("ModelOperation")]
                [Validation(Required=false)]
                public string ModelOperation { get; set; }

                /// <summary>
                /// <para>The UID of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d4bcfaec1946e1870d</para>
                /// </summary>
                [NameInMap("ModelUid")]
                [Validation(Required=false)]
                public string ModelUid { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>647CEF05-404C-4125-B3D7-44792EB77392</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The APIs that are created based on the Swagger-compliant data imported this time.</para>
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
                /// <para>Specifies whether the operation is CREATE or MODIFY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE</para>
                /// </summary>
                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                /// <summary>
                /// <para>The UID of the successfully imported API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8e274ec61cf6468e83b68371956831cb</para>
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// <para>The HTTP method configured when the API is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The request path configured when the API is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/http/get/mapping</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

    }

}
