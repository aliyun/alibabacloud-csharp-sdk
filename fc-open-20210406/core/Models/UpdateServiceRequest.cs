// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateServiceRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
