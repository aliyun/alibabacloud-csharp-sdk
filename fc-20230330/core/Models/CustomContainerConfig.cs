// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomContainerConfig : TeaModel {
        [NameInMap("accelerationInfo")]
        [Validation(Required=false)]
        public AccelerationInfo AccelerationInfo { get; set; }

        [NameInMap("accelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("entrypoint")]
        [Validation(Required=false)]
        public List<string> Entrypoint { get; set; }

        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig HealthCheckConfig { get; set; }

        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public RegistryConfig RegistryConfig { get; set; }

        [NameInMap("resolvedImageUri")]
        [Validation(Required=false)]
        public string ResolvedImageUri { get; set; }

    }

}
