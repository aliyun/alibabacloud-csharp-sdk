// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableZoneRequest : TeaModel {
        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("ObVersion")]
        [Validation(Required=false)]
        public string ObVersion { get; set; }

        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
