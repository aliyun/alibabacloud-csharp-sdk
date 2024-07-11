// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The instances.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// Indicates whether the instance is automatically renewed.
                /// </summary>
                [NameInMap("AutoRenewInstance")]
                [Validation(Required=false)]
                public bool? AutoRenewInstance { get; set; }

                /// <summary>
                /// The endpoint that is used to access the instance over the classic network. This parameter is no longer available.
                /// </summary>
                [NameInMap("ClassicEndpoint")]
                [Validation(Required=false)]
                public string ClassicEndpoint { get; set; }

                /// <summary>
                /// The timestamp that indicates when the instance expires. Unit: milliseconds.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// The instance ID
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The instance type.
                /// 
                /// *   PROFESSIONAL: Professional Edition
                /// *   ENTERPRISE: Enterprise Edition
                /// *   VIP: Enterprise Platinum Edition
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The maximum number of Internet-based transactions per second (TPS) for the instance.
                /// </summary>
                [NameInMap("MaxEipTps")]
                [Validation(Required=false)]
                public int? MaxEipTps { get; set; }

                /// <summary>
                /// The maximum number of queues on the instance.
                /// </summary>
                [NameInMap("MaxQueue")]
                [Validation(Required=false)]
                public int? MaxQueue { get; set; }

                /// <summary>
                /// The maximum number of VPC-based TPS for the instance.
                /// </summary>
                [NameInMap("MaxTps")]
                [Validation(Required=false)]
                public int? MaxTps { get; set; }

                /// <summary>
                /// The maximum number of vhosts on the instance.
                /// </summary>
                [NameInMap("MaxVhost")]
                [Validation(Required=false)]
                public int? MaxVhost { get; set; }

                /// <summary>
                /// The timestamp that indicates when the order was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("OrderCreateTime")]
                [Validation(Required=false)]
                public long? OrderCreateTime { get; set; }

                /// <summary>
                /// The billing method. Valid values:
                /// 
                /// *   PrePaid: the subscription billing method.
                /// *   POST_PAID: the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) endpoint of the instance.
                /// </summary>
                [NameInMap("PrivateEndpoint")]
                [Validation(Required=false)]
                public string PrivateEndpoint { get; set; }

                /// <summary>
                /// The public endpoint of the instance.
                /// </summary>
                [NameInMap("PublicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// The instance status. Valid values:
                /// 
                /// *   DEPLOYING: The instance is being deployed.
                /// *   EXPIRED: The instance is expired.
                /// *   SERVING: The instance is running.
                /// *   RELEASED: The instance is released.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The disk size. Unit: GB.
                /// 
                /// >  For Professional Edition instances and Enterprise Edition instances, this parameter is unavailable and \\*\\*-1\\*\\* is returned.
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

                /// <summary>
                /// Indicates whether the instance supports elastic IP addresses (EIPs).
                /// </summary>
                [NameInMap("SupportEIP")]
                [Validation(Required=false)]
                public bool? SupportEIP { get; set; }

                /// <summary>
                /// 标签列表。
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataInstancesTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataInstancesTags : TeaModel {
                    /// <summary>
                    /// 标签键。
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// 标签值。
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
