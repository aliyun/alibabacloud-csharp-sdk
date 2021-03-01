// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListMethodsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceMethodList")]
        [Validation(Required=false)]
        public ListMethodsResponseBodyServiceMethodList ServiceMethodList { get; set; }
        public class ListMethodsResponseBodyServiceMethodList : TeaModel {
            [NameInMap("ServiceMethod")]
            [Validation(Required=false)]
            public List<ListMethodsResponseBodyServiceMethodListServiceMethod> ServiceMethod { get; set; }
            public class ListMethodsResponseBodyServiceMethodListServiceMethod : TeaModel {
                public string MethodName { get; set; }
                public ListMethodsResponseBodyServiceMethodListServiceMethodParamTypes ParamTypes { get; set; }
                public class ListMethodsResponseBodyServiceMethodListServiceMethodParamTypes : TeaModel {
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public List<string> ParamType { get; set; }

                }
                public ListMethodsResponseBodyServiceMethodListServiceMethodInputParams InputParams { get; set; }
                public class ListMethodsResponseBodyServiceMethodListServiceMethodInputParams : TeaModel {
                    [NameInMap("InputParam")]
                    [Validation(Required=false)]
                    public List<string> InputParam { get; set; }

                }
                public string AppName { get; set; }
                public string Output { get; set; }
                public string ServiceName { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
