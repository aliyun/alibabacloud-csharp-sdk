// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the total number of resources. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries the total number of resources and returns the result in the TotalCount parameter.</description></item>
        /// <item><description>false: Does not query the total number of resources. The TotalCount parameter returns -1, and the resources are still paginated based on the PageNumber and PageSize parameters.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public bool? Count { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uPJpP****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-23v38****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of resource types. A maximum of 50 resource types are supported.</para>
        /// <remarks>
        /// <para>If you configure the Settings for ResourceTypes, the Service and ResourceType request parameter specified separately do not take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<ListResourcesRequestResourceTypes> ResourceTypes { get; set; }
        public class ListResourcesRequestResourceTypes : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// <remarks>
            /// <para>The Service and ResourceType parameters in ResourceTypes must be specified at the same time. Otherwise, they do not take effect.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>You can obtain the code from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// <remarks>
            /// <para>The Service and ResourceType parameters in ResourceTypes must be specified at the same time. Otherwise, they do not take effect.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <para>The code of the cloud service.</para>
        /// <para>You can obtain the code from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
