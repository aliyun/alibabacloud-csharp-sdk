// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestDataServiceApiRequest : TeaModel {
        /// <summary>
        /// API Id
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        [NameInMap("BodyContent")]
        [Validation(Required=false)]
        public string BodyContent { get; set; }

        [NameInMap("BodyParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestBodyParams> BodyParams { get; set; }
        public class TestDataServiceApiRequestBodyParams : TeaModel {
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        [NameInMap("HeadParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestHeadParams> HeadParams { get; set; }
        public class TestDataServiceApiRequestHeadParams : TeaModel {
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        [NameInMap("PathParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestPathParams> PathParams { get; set; }
        public class TestDataServiceApiRequestPathParams : TeaModel {
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        [NameInMap("QueryParam")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestQueryParam> QueryParam { get; set; }
        public class TestDataServiceApiRequestQueryParam : TeaModel {
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

    }

}
