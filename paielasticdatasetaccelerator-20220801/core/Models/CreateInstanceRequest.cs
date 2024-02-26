// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MaxEndpoint")]
        [Validation(Required=false)]
        public string MaxEndpoint { get; set; }

        [NameInMap("MaxSlot")]
        [Validation(Required=false)]
        public string MaxSlot { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
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

    }

}
