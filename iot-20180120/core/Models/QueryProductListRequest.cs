// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductListRequest : TeaModel {
        /// <summary>
        /// The type of the product. Valid values:
        /// 
        /// *   **iothub_senior**: A Thing Specification Language (TSL) model is used for the product.
        /// *   **iothub**: No TSL model is used for the product.
        /// 
        /// >  If you do not configure this parameter, all products are returned.
        /// </summary>
        [NameInMap("AliyunCommodityCode")]
        [Validation(Required=false)]
        public string AliyunCommodityCode { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// > *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// > *   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 200.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the product belongs. You can log on to the [Resource Management](https://resourcemanager.console.aliyun.com/resource-groups) console to view the details of the resource group.
        /// 
        /// > You can specify a value for this parameter only if you have activated Resource Management.
        /// 
        /// If you leave this parameter empty, the information about all products in the current account is queried.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
