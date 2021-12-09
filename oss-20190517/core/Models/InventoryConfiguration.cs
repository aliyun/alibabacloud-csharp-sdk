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

        /// <summary>
        /// The specified inventory list name, which must be globally unique in the bucket
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncludedObjectVersions")]
        [Validation(Required=false)]
        public string IncludedObjectVersions { get; set; }

        /// <summary>
        /// Indicates whether the inventory function is enabled
        /// </summary>
        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// The container that stores the configuration fields included in the inventory list
        /// </summary>
        [NameInMap("OptionalFields")]
        [Validation(Required=false)]
        public InventoryConfigurationOptionalFields OptionalFields { get; set; }
        public class InventoryConfigurationOptionalFields : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }
        };

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public InventorySchedule Schedule { get; set; }

    }

}
