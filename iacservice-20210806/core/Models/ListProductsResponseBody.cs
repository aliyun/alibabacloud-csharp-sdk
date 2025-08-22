// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30BaZ9ekYWXJdqshYecA++coNg7qT1Zbm3RfLyFIZeY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            [NameInMap("firstCategoryName")]
            [Validation(Required=false)]
            public string FirstCategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enterprise application</para>
            /// </summary>
            [NameInMap("firstCategoryNameEn")]
            [Validation(Required=false)]
            public string FirstCategoryNameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MSE</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Microservices Engine</para>
            /// </summary>
            [NameInMap("productNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            [NameInMap("secondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Application service</para>
            /// </summary>
            [NameInMap("secondCategoryNameEn")]
            [Validation(Required=false)]
            public string SecondCategoryNameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Microservice_Engine(MSE)</para>
            /// </summary>
            [NameInMap("subcategory")]
            [Validation(Required=false)]
            public string Subcategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportTerraformer")]
            [Validation(Required=false)]
            public bool? SupportTerraformer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.229.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9bcaac3c-420d-4303-87ab-7638c07b0a0b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>134</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
