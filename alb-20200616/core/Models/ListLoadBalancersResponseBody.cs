// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// 实例列表
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// 访问日志属性
            /// </summary>
            [NameInMap("AccessLogConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig AccessLogConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig : TeaModel {
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }
            };

            /// <summary>
            /// 地址模式
            /// </summary>
            [NameInMap("AddressAllocatedMode")]
            [Validation(Required=false)]
            public string AddressAllocatedMode { get; set; }

            /// <summary>
            /// 协议版本
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// 地址类型
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// 带宽包ID
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// 资源创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// DNS域名
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// 负载均衡删除保护相关信息
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }
            };

            /// <summary>
            /// IPV6地址类型
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// 计费相关属性
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }
            };

            /// <summary>
            /// 实例业务状态
            /// </summary>
            [NameInMap("LoadBalancerBussinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBussinessStatus { get; set; }

            /// <summary>
            /// 负载均衡的版本
            /// </summary>
            [NameInMap("LoadBalancerEdition")]
            [Validation(Required=false)]
            public string LoadBalancerEdition { get; set; }

            /// <summary>
            /// 负载均衡标识
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// 实例名称
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// 锁定的原因
            /// </summary>
            [NameInMap("LoadBalancerOperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks : TeaModel {
                /// <summary>
                /// 锁定的原因
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// 锁定的类型
                /// </summary>
                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

            }

            /// <summary>
            /// 实例状态
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// 负载均衡修改保护相关信息
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
            };

            /// <summary>
            /// 企业资源组ID
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// 标签列表
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
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
            /// Vpc网络ID
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 用来表示当前调用返回读取到的位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
