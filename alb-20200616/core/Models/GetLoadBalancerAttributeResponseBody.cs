// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// 访问日志属性
        /// </summary>
        [NameInMap("AccessLogConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyAccessLogConfig AccessLogConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyAccessLogConfig : TeaModel {
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }
        };

        /// <summary>
        /// 地址分配方式
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

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
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }
        };

        /// <summary>
        /// 计费相关属性
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
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
        /// 锁定原因
        /// </summary>
        [NameInMap("LoadBalancerOperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks : TeaModel {
            /// <summary>
            /// 锁定原因
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// 锁定类型
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
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        /// <summary>
        /// 地域
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
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

        /// <summary>
        /// 负载均衡的可用区资源
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// 固定VIP模式下，负载均衡在此可用区中的地址列表
            /// </summary>
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
                /// <summary>
                /// IP地址
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

            }

            /// <summary>
            /// 交换机标识
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// 可用区标识
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
