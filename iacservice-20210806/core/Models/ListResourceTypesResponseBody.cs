// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 0 to 200. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LC4NJL3Ru2bIiRdnbADPQp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9bcaac3c-420d-4303-87ab-7638c07b0a0b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("resourceTypes")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypes> ResourceTypes { get; set; }
        public class ListResourceTypesResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>路由表</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>专有网络VPC</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The URL of the resource details page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://vpc.console.aliyun.com/vpc/$%7BRegionId%7D/route-tables/$%7BRouteTableId%7D">https://vpc.console.aliyun.com/vpc/${RegionId}/route-tables/${RouteTableId}</a></para>
            /// </summary>
            [NameInMap("resourceDetailPageUrl")]
            [Validation(Required=false)]
            public string ResourceDetailPageUrl { get; set; }

            /// <summary>
            /// <para>The URL of the resources page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://vpc.console.aliyun.com/vpc/$%7BRegionId%7D/route-tables">https://vpc.console.aliyun.com/vpc/${RegionId}/route-tables</a></para>
            /// </summary>
            [NameInMap("resourceListPageUrl")]
            [Validation(Required=false)]
            public string ResourceListPageUrl { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version from which the resource status takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("statusStartVersion")]
            [Validation(Required=false)]
            public string StatusStartVersion { get; set; }

            /// <summary>
            /// <para>The product subcategory in Terraform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("subcategory")]
            [Validation(Required=false)]
            public string Subcategory { get; set; }

            /// <summary>
            /// <para>Specifies whether Terraformer is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportTerraformer")]
            [Validation(Required=false)]
            public string SupportTerraformer { get; set; }

            /// <summary>
            /// <para>The Terraform provider version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.248.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <para>The resource type in Terraform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_route_table</para>
            /// </summary>
            [NameInMap("terraformResourceType")]
            [Validation(Required=false)]
            public string TerraformResourceType { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>路由表</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
