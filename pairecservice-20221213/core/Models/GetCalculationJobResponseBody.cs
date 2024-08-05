// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetCalculationJobResponseBody : TeaModel {
        [NameInMap("ABMetricId")]
        [Validation(Required=false)]
        public string ABMetricId { get; set; }

        [NameInMap("ABMetricName")]
        [Validation(Required=false)]
        public string ABMetricName { get; set; }

        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("GmtRanTime")]
        [Validation(Required=false)]
        public string GmtRanTime { get; set; }

        [NameInMap("JobMessage")]
        [Validation(Required=false)]
        public List<string> JobMessage { get; set; }

        [NameInMap("JobSource")]
        [Validation(Required=false)]
        public string JobSource { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
