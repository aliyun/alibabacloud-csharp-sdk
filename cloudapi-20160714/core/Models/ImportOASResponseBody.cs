// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASResponseBody : TeaModel {
        /// <summary>
        /// <para>The error messages that appear due to the invalid data in the imported file.</para>
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
        /// <para>The APIs that failed to pass the precheck.</para>
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
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Invalid Api Definition.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The HTTP method configured when you created the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The request path configured when you created the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/st1</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the models that failed to pass the precheck.</para>
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
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Invalid Model Definition.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2c1bc62e19614cc68c6b0b484bc9c5db</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the asynchronous API import task that was generated during the import operation. This ID is used to query the execution status of the API import task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c16a1880f5164d779f6a54f64d997cd9</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7FE7172-AA75-5880-B6F7-C00893E9BC06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the APIs that have passed the precheck.</para>
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
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92af1abffc2443eaa2b815fdbd9c13f1</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>Indicates that the operation is CREATE or MODIFY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE</para>
                /// </summary>
                [NameInMap("ApiOperation")]
                [Validation(Required=false)]
                public string ApiOperation { get; set; }

                /// <summary>
                /// <para>The HTTP method configured when you created the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The request path configured when you created the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/st1</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the models that have passed the precheck.</para>
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
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feaccf67040643bcbdedb253e59eb527</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The operation of the model. Valid values: CREATE and MODIFY.</para>
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
                /// <para>1r4efwee19614cc68c6b0b484bc9c5dbs</para>
                /// </summary>
                [NameInMap("ModelUid")]
                [Validation(Required=false)]
                public string ModelUid { get; set; }

            }

        }

        /// <summary>
        /// <para>The warning messages that appear due to the invalid data in the imported file.</para>
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
