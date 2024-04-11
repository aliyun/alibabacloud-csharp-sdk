// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The deployment mode of the instance. Valid values:
        /// 
        /// *   **4**: deploys the instance that allows access from the Internet and a VPC.
        /// *   **5**: deploys the instance that allows access only from a VPC.
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// The disk size.
        /// 
        /// For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The disk type. Valid values:
        /// 
        /// *   **0**: ultra disk
        /// *   **1**: standard SSD
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// The Internet traffic for the instance.
        /// 
        /// *   This parameter is required if the **DeployType** parameter is set to **4**.
        /// *   For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// The maximum traffic for the instance. We recommend that you do not configure this parameter.
        /// 
        /// *   You must specify at least one of the IoMax and IoMaxSpec parameters. If you configure both parameters, the value of the IoMaxSpec parameter takes effect. We recommend that you specify only the IoMaxSpec parameter.
        /// *   For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// The traffic specification of the instance. We recommend that you configure this parameter.
        /// 
        /// *   You must specify at least one of the IoMax and IoMaxSpec parameters. If you configure both parameters, the value of the IoMaxSpec parameter takes effect. We recommend that you specify only the IoMaxSpec parameter.
        /// *   For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// The number of partitions. We recommend that you configure this parameter.
        /// 
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// If this parameter is left empty, the default resource group is used. You can view the resource group ID on the Resource Group page in the Resource Management console.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// The edition of the instance. Valid values:
        /// 
        /// *   **normal**: Standard Edition (High Write)
        /// *   **professional**: Professional Edition (High Write)
        /// *   **professionalForHighRead**: Professional Edition (High Read)
        /// 
        /// For more information about these instance editions, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePostPayOrderShrinkRequestTag> Tag { get; set; }
        public class CreatePostPayOrderShrinkRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   If this parameter is left empty, the keys of all tags are matched.
            /// *   The tag key must be up to 128 characters in length. It cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   If you do not specify a tag key, you cannot specify a tag value. If this parameter is not configured, all tag values are matched.
            /// *   The tag value must be 1 to 128 characters in length. It cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of topics. We recommend that you do not configure this parameter.
        /// 
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   The default value of the TopicQuota parameter varies based on the value of the IoMaxSpec parameter. If the number of topics that you consume exceeds the default value, you are charged additional fees.
        /// *   For more information about the valid values, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
