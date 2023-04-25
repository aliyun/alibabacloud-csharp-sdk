// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListRequest : TeaModel {
        /// <summary>
        /// The IDs of instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The ID of the order. You can obtain the order ID on the [Orders](https://usercenter2-intl.aliyun.com/order/list?pageIndex=1\&pageSize=20\&spm=5176.12818093.top-nav.ditem-ord.36f016d0OQFmJa) page in Alibaba Cloud User Center.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can obtain this ID on the Resource Group page in the Resource Management console.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetInstanceListRequestTag> Tag { get; set; }
        public class GetInstanceListRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is attached to the resource.
            /// 
            /// *   If this parameter is left empty, all tag keys are matched.
            /// *   A tag key can be up to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is attached to the resource.
            /// 
            /// *   If the Key parameter is left empty, this parameter must be left empty. If this parameter is left empty, all tag values are matched.
            /// *   A tag key can be up to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
