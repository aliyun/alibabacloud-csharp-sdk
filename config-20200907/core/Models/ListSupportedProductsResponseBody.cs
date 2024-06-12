// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListSupportedProductsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries to return for a single request. Valid values: 1 to 500.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The cloud services that are supported by Cloud Config.
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListSupportedProductsResponseBodyProducts> Products { get; set; }
        public class ListSupportedProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// The English name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            /// <summary>
            /// The Chinese name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ProductNameZh")]
            [Validation(Required=false)]
            public string ProductNameZh { get; set; }

            /// <summary>
            /// The resource types that are supported by Cloud Config.
            /// </summary>
            [NameInMap("ResourceTypeList")]
            [Validation(Required=false)]
            public List<ListSupportedProductsResponseBodyProductsResourceTypeList> ResourceTypeList { get; set; }
            public class ListSupportedProductsResponseBodyProductsResourceTypeList : TeaModel {
                /// <summary>
                /// The identifier of the resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The English name of the resource type.
                /// </summary>
                [NameInMap("TypeNameEn")]
                [Validation(Required=false)]
                public string TypeNameEn { get; set; }

                /// <summary>
                /// The Chinese name of the resource type.
                /// </summary>
                [NameInMap("TypeNameZh")]
                [Validation(Required=false)]
                public string TypeNameZh { get; set; }

                /// <summary>
                /// The URL of the resource type in the console.
                /// </summary>
                [NameInMap("TypePageLink")]
                [Validation(Required=false)]
                public string TypePageLink { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
