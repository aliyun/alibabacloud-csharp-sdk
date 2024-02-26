// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("IoType")]
            [Validation(Required=false)]
            public string IoType { get; set; }

            /// <summary>
            /// 数据集加速实例的最大挂载点个数。
            /// </summary>
            [NameInMap("MaxEndpoint")]
            [Validation(Required=false)]
            public int? MaxEndpoint { get; set; }

            [NameInMap("MaxSlot")]
            [Validation(Required=false)]
            public int? MaxSlot { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// 数据集加速实例的资源提供者类型。
            /// </summary>
            [NameInMap("ProviderType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public InstanceStatus Status { get; set; }

            /// <summary>
            /// 数据集加速实例的存储类型。
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class ListInstancesResponseBodyInstancesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
