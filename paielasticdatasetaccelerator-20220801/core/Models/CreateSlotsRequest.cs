// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class CreateSlotsRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<CreateSlotsRequestSlots> Slots { get; set; }
        public class CreateSlotsRequestSlots : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndpointIds")]
            [Validation(Required=false)]
            public string EndpointIds { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IoType")]
            [Validation(Required=false)]
            public string IoType { get; set; }

            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public SlotLifeCycle LifeCycle { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("StorageUri")]
            [Validation(Required=false)]
            public string StorageUri { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreateSlotsRequestSlotsTags> Tags { get; set; }
            public class CreateSlotsRequestSlotsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
