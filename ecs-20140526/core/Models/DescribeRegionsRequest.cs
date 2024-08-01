// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The natural language that is used to filter responses. For more information, see [RFC 7231](https://tools.ietf.org/html/rfc7231). Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// 
        /// Default value: zh-CN.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The billing method of instances. For more information, see [Billing overview](https://help.aliyun.com/document_detail/25398.html). Valid values:
        /// 
        /// *   PrePaid: subscription. If you set this parameter to PrePaid, make sure that you have sufficient balance or credits in your account. Otherwise, the InvalidPayMethod error code is returned.
        /// *   PostPaid: pay-as-you-go.
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The resource type. Valid value:
        /// 
        /// *   instance: Elastic Compute Service (ECS) instance
        /// *   disk: disk
        /// *   reservedinstance: reserved instance
        /// *   scu: storage capacity unit (SCU)
        /// 
        /// Default value: instance.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
