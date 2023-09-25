/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class ConfigurationSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigurationSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigurationSynchronizationJobRequestDestinationEndpoint : TeaModel {
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("Initialization")]
        [Validation(Required=false)]
        public ConfigurationSynchronizationJobRequestInitialization Initialization { get; set; }
        public class ConfigurationSynchronizationJobRequestInitialization : TeaModel {
            [NameInMap("DataLoad")]
            [Validation(Required=false)]
            public bool? DataLoad { get; set; }

            [NameInMap("StructureLoad")]
            [Validation(Required=false)]
            public bool? StructureLoad { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigurationSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigurationSynchronizationJobRequestSourceEndpoint : TeaModel {
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        [NameInMap("SynchronizationObject")]
        [Validation(Required=false)]
        public string SynchronizationObject { get; set; }

    }

}
