// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InventoryConfiguration : TeaModel {
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public InventoryDestination Destination { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public InventoryFilter Filter { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncludedObjectVersions")]
        [Validation(Required=false)]
        public string IncludedObjectVersions { get; set; }

        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public bool? IsEnabled { get; set; }

        [NameInMap("OptionalFields")]
        [Validation(Required=false)]
        public InventoryConfigurationOptionalFields OptionalFields { get; set; }
        public class InventoryConfigurationOptionalFields : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

        }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public InventorySchedule Schedule { get; set; }

    }

}
