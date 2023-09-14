// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateRequest : TeaModel {
        [NameInMap("ApplyEndTime")]
        [Validation(Required=false)]
        public string ApplyEndTime { get; set; }

        [NameInMap("ApplyStartTime")]
        [Validation(Required=false)]
        public string ApplyStartTime { get; set; }

        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
