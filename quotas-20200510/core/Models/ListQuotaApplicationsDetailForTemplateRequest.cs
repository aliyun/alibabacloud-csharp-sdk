// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsDetailForTemplateRequest : TeaModel {
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

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

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
