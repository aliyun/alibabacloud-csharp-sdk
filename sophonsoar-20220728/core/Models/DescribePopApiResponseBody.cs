// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiResponseBody : TeaModel {
        /// <summary>
        /// The name of the API.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The information about the API.
        /// </summary>
        [NameInMap("OpenApiMetaList")]
        [Validation(Required=false)]
        public List<DescribePopApiResponseBodyOpenApiMetaList> OpenApiMetaList { get; set; }
        public class DescribePopApiResponseBodyOpenApiMetaList : TeaModel {
            /// <summary>
            /// The parameter description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The example value.
            /// </summary>
            [NameInMap("ExampleValue")]
            [Validation(Required=false)]
            public string ExampleValue { get; set; }

            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the parameter is required.
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// The data type of the parameter field. Valid values:
            /// 
            /// *   **string**
            /// *   **boolean**
            /// *   **integer**
            /// *   **long**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The POP code of the Alibaba Cloud service.
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The version of the API.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
