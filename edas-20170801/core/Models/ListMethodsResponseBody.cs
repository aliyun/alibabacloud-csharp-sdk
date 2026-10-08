// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListMethodsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69AD2AA7-DB47-449B-941B-B14409DF****</para>
        /// </summary>
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

                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

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

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

    }

}
