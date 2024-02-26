// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListSlotsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<ListSlotsResponseBodySlots> Slots { get; set; }
        public class ListSlotsResponseBodySlots : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListSlotsResponseBodySlotsEndpoints> Endpoints { get; set; }
            public class ListSlotsResponseBodySlotsEndpoints : TeaModel {
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public EndpointStatus Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 数据集加速槽的读写类型。
            /// </summary>
            [NameInMap("IoType")]
            [Validation(Required=false)]
            public string IoType { get; set; }

            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public SlotLifeCycle LifeCycle { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public SlotStatus Status { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("StorageUri")]
            [Validation(Required=false)]
            public string StorageUri { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSlotsResponseBodySlotsTags> Tags { get; set; }
            public class ListSlotsResponseBodySlotsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
