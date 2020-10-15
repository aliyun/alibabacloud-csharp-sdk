// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("RescaleType")]
        [Validation(Required=true)]
        public string RescaleType { get; set; }

        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        [NameInMap("ResourceSelector")]
        [Validation(Required=true)]
        public string ResourceSelector { get; set; }

        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
