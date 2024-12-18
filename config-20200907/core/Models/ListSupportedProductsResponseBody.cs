// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListSupportedProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return for a single request. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D3AjqMNSy0ls7zBNCf3a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The cloud services that are supported by Cloud Config.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListSupportedProductsResponseBodyProducts> Products { get; set; }
        public class ListSupportedProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// <para>The English name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            /// <summary>
            /// <para>The Chinese name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云服务器ECS</para>
            /// </summary>
            [NameInMap("ProductNameZh")]
            [Validation(Required=false)]
            public string ProductNameZh { get; set; }

            /// <summary>
            /// <para>The resource types that are supported by Cloud Config.</para>
            /// </summary>
            [NameInMap("ResourceTypeList")]
            [Validation(Required=false)]
            public List<ListSupportedProductsResponseBodyProductsResourceTypeList> ResourceTypeList { get; set; }
            public class ListSupportedProductsResponseBodyProductsResourceTypeList : TeaModel {
                /// <summary>
                /// <para>The identifier of the resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The English name of the resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ecs Instance</para>
                /// </summary>
                [NameInMap("TypeNameEn")]
                [Validation(Required=false)]
                public string TypeNameEn { get; set; }

                /// <summary>
                /// <para>The Chinese name of the resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS实例</para>
                /// </summary>
                [NameInMap("TypeNameZh")]
                [Validation(Required=false)]
                public string TypeNameZh { get; set; }

                /// <summary>
                /// <para>The URL of the resource type in the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ecs.console.aliyun.com/#/server/@%7BResourceId%7D/detail?regionId=@%7BRegionId%7D">https://ecs.console.aliyun.com/#/server/@{ResourceId}/detail?regionId=@{RegionId}</a></para>
                /// </summary>
                [NameInMap("TypePageLink")]
                [Validation(Required=false)]
                public string TypePageLink { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>610B0276-ABEE-57DF-9C13-C2324FADA9D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
