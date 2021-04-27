// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        [NameInMap("DriverVersion")]
        [Validation(Required=false)]
        public string DriverVersion { get; set; }

        [NameInMap("VersionState")]
        [Validation(Required=false)]
        public int? VersionState { get; set; }

    }

}
