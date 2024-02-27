// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListEnhanhcedNatGatewayAvailableZonesRequest : TeaModel {
        /// <summary>
        /// The language to display the results. Valid values:
        /// 
        /// *   **zh-CN** (default): Chinese
        /// *   **en-US**: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The filter information. You can specify a filter key and a filter value.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListEnhanhcedNatGatewayAvailableZonesRequestFilter> Filter { get; set; }
        public class ListEnhanhcedNatGatewayAvailableZonesRequestFilter : TeaModel {
            /// <summary>
            /// The filter key. Only **PrivateLinkEnabled** is supported.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter key.
            /// 
            /// >  If the filter key is set to **PrivateLinkEnabled**, you must specify a filter value. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region that you want to query.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// 
        /// In this example, zones that support NAT gateways in the UAE (Dubai) region are queried.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
