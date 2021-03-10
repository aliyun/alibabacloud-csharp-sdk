// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeDriverVersionRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DriverId")]
        [Validation(Required=true)]
        public string DriverId { get; set; }

        [NameInMap("DriverVersion")]
        [Validation(Required=true)]
        public string DriverVersion { get; set; }

        [NameInMap("EdgeVersion")]
        [Validation(Required=true)]
        public string EdgeVersion { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfig { get; set; }

        [NameInMap("DriverConfig")]
        [Validation(Required=false)]
        public string DriverConfig { get; set; }

        [NameInMap("ContainerConfig")]
        [Validation(Required=false)]
        public string ContainerConfig { get; set; }

        [NameInMap("ConfigCheckRule")]
        [Validation(Required=false)]
        public string ConfigCheckRule { get; set; }

        [NameInMap("Argument")]
        [Validation(Required=false)]
        public string Argument { get; set; }

    }

}
