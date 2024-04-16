// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ReleaseVersionImage : TeaModel {
        [NameInMap("cpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("runtimeEngineType")]
        [Validation(Required=false)]
        public string RuntimeEngineType { get; set; }

    }

}
