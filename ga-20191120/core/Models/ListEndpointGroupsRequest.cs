// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// Specifies whether the access logging feature is enabled. Default value: off. Valid values:
        /// 
        /// *   **on**: The access logging feature is enabled.
        /// *   **off**: The access logging feature is disabled.
        /// </summary>
        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The type of the endpoint group. Valid values:
        /// 
        /// *   **default**
        /// *   **virtual**
        /// *   If you leave this parameter empty, all default and virtual endpoint groups are queried.
        /// </summary>
        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tag of the endpoint group.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListEndpointGroupsRequestTag> Tag { get; set; }
        public class ListEndpointGroupsRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the endpoint group. It cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the endpoint group. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
