// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// For more information about the supported resource types, see the **Resource type** column in [Services that work with Resource Group](~~94479~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The resource types. A maximum of 50 resource types are supported.
        /// 
        /// >  If you configure `ResourceTypes`, you must configure both `Service` and `ResourceType`. Otherwise, the configured Service or ResourceType does not take effect.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<ListResourcesRequestResourceTypes> ResourceTypes { get; set; }
        public class ListResourcesRequestResourceTypes : TeaModel {
            /// <summary>
            /// The resource type.
            /// 
            /// Valid values of N: 1 to 50.
            /// 
            /// For more information about the supported resource types, see the **Resource type** column in [Services that work with Resource Group](~~94479~~).
            /// 
            /// >  You must configure both `Service` and `ResourceType` in `ResourceTypes`. Otherwise, the two parameters do not take effect.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud service.
            /// 
            /// Valid values of N: 1 to 50.
            /// 
            /// You can obtain the ID from the **Service code** column in [Services that work with Resource Group](~~94479~~).
            /// 
            /// >  You must configure both `Service` and `ResourceType` in `ResourceTypes`. Otherwise, the two parameters do not take effect.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud service.
        /// 
        /// You can obtain the ID from the **Service code** column in [Services that work with Resource Group](~~94479~~).
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
