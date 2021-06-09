// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// 用来标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量，此参数为可选参数，取值1-100，用户传入为空时，默认为20。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 可用区ID
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// 实例业务状态
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// 实例ID列表，N最大支持20
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// 实例Name列表，N最大支持10
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// vpcId列表
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// tag列表
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// 实例的标签键
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 实例的标签值
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 负载均衡的地址类型
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// 付费类型
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// 资源组ID
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
