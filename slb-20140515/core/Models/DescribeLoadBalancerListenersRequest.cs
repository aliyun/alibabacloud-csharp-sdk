// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerListenersRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The protocol used by the listener. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// *   **http**
        /// *   **https**
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ID of the CLB instance. You can specify at most 10 IDs.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public List<string> LoadBalancerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: **1** to **100**. If you do not specify a value, the default value **20** is used.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first query and no subsequent queries are to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can call the [DescribeRegions](~~DescribeRegions~~) operation to query the most recent region list.
        /// 
        /// >  If the endpoint of the selected region is slb.aliyuncs.com, the `RegionId` parameter is required.
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

        /// <summary>
        /// 标签列表。
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenersRequestTag> Tag { get; set; }
        public class DescribeLoadBalancerListenersRequestTag : TeaModel {
            /// <summary>
            /// 资源的标签键。N的取值范围：**1~20**。一旦输入该值，则不允许为空字符串。
            /// 
            /// 最多支持64个字符，不能以`aliyun`和`acs:`开头，不能包含`http://`或者`https://`。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 资源的标签值。N的取值范围：**1~20**。一旦输入该值，可以为空字符串。
            /// 最多支持128个字符，不能以`aliyun`和`acs:`开头，不能包含`http://`或者`https://`。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
