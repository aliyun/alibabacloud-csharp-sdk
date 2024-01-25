// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateBusinessMetricAlertConfigRequest : TeaModel {
        [NameInMap("AlertConfigId")]
        [Validation(Required=false)]
        public long? AlertConfigId { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string Configs { get; set; }

        [NameInMap("MetricId")]
        [Validation(Required=false)]
        public long? MetricId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
