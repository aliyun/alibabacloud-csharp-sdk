// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateResponseBody : TeaModel {
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
