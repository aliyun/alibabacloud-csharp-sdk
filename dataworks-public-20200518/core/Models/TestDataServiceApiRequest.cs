// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestDataServiceApiRequest : TeaModel {
        /// <summary>
        /// The ID of the DataService Studio API on which the test is performed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// The data of the request body.
        /// </summary>
        [NameInMap("BodyContent")]
        [Validation(Required=false)]
        public string BodyContent { get; set; }

        /// <summary>
        /// The request parameters that are contained in the request body.
        /// </summary>
        [NameInMap("BodyParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestBodyParams> BodyParams { get; set; }
        public class TestDataServiceApiRequestBodyParams : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// The request parameters that are contained in the request header.
        /// </summary>
        [NameInMap("HeadParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestHeadParams> HeadParams { get; set; }
        public class TestDataServiceApiRequestHeadParams : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// The request parameters that are contained in the request path.
        /// </summary>
        [NameInMap("PathParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestPathParams> PathParams { get; set; }
        public class TestDataServiceApiRequestPathParams : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// The request parameters that are contained in the query.
        /// </summary>
        [NameInMap("QueryParam")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestQueryParam> QueryParam { get; set; }
        public class TestDataServiceApiRequestQueryParam : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

    }

}
