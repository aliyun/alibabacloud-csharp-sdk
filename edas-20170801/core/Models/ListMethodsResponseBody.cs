// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListMethodsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message that indicates whether the request is successful.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about service methods.
        /// </summary>
        [NameInMap("ServiceMethodList")]
        [Validation(Required=false)]
        public ListMethodsResponseBodyServiceMethodList ServiceMethodList { get; set; }
        public class ListMethodsResponseBodyServiceMethodList : TeaModel {
            [NameInMap("ServiceMethod")]
            [Validation(Required=false)]
            public List<ListMethodsResponseBodyServiceMethodListServiceMethod> ServiceMethod { get; set; }
            public class ListMethodsResponseBodyServiceMethodListServiceMethod : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("InputParams")]
                [Validation(Required=false)]
                public ListMethodsResponseBodyServiceMethodListServiceMethodInputParams InputParams { get; set; }
                public class ListMethodsResponseBodyServiceMethodListServiceMethodInputParams : TeaModel {
                    [NameInMap("InputParam")]
                    [Validation(Required=false)]
                    public List<string> InputParam { get; set; }

                }

                /// <summary>
                /// The name of the service method.
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// The return type of the service method.
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                [NameInMap("ParamTypes")]
                [Validation(Required=false)]
                public ListMethodsResponseBodyServiceMethodListServiceMethodParamTypes ParamTypes { get; set; }
                public class ListMethodsResponseBodyServiceMethodListServiceMethodParamTypes : TeaModel {
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public List<string> ParamType { get; set; }

                }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

    }

}
