// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
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
        /// <para>The detailed information about the resource type.</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public GetResourceTypeResponseBodyResourceType ResourceType { get; set; }
        public class GetResourceTypeResponseBodyResourceType : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The collection of APIs associated with the resource.</para>
            /// </summary>
            [NameInMap("operations")]
            [Validation(Required=false)]
            public List<GetResourceTypeResponseBodyResourceTypeOperations> Operations { get; set; }
            public class GetResourceTypeResponseBodyResourceTypeOperations : TeaModel {
                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateVSwitch</para>
                /// </summary>
                [NameInMap("apiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The API version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-04-28</para>
                /// </summary>
                [NameInMap("apiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                /// <summary>
                /// <para>The operation type. Valid values: Write, Read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Write</para>
                /// </summary>
                [NameInMap("operationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>serviceCode</para>
                /// 
                /// <b>Example:</b>
                /// <para>Vpc</para>
                /// </summary>
                [NameInMap("serviceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

            }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
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
            /// <para>The English name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("productNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            /// <summary>
            /// <para>The resource properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

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

            /// <summary>
            /// <para>The Alibaba Cloud resource type, in the format of ALIYUN::<cloud service>::<resource type>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::VPC::VPC</para>
            /// </summary>
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
            /// <para>The version from which the status takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.227.0</para>
            /// </summary>
            [NameInMap("statusStartVersion")]
            [Validation(Required=false)]
            public string StatusStartVersion { get; set; }

            /// <summary>
            /// <para>The product category in Terraform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network</para>
            /// </summary>
            [NameInMap("subcategory")]
            [Validation(Required=false)]
            public string Subcategory { get; set; }

            /// <summary>
            /// <para>Indicates whether export is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportExported")]
            [Validation(Required=false)]
            public bool? SupportExported { get; set; }

            /// <summary>
            /// <para>The Terraform provider version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.227.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <para>The resource code in Terraform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_vpc</para>
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

    }

}
