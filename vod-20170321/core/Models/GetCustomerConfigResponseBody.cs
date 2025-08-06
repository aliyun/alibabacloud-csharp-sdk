// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCustomerConfigResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuditConfig")]
        [Validation(Required=false)]
        public string AuditConfig { get; set; }

        [NameInMap("DownloadSwitch")]
        [Validation(Required=false)]
        public string DownloadSwitch { get; set; }

        [NameInMap("MetricConfig")]
        [Validation(Required=false)]
        public string MetricConfig { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
