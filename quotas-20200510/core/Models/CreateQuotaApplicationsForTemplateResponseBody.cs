// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud accounts for which the quotas are applied.
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// The ID of the quota application batch.
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        [NameInMap("FailResults")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateResponseBodyFailResults> FailResults { get; set; }
        public class CreateQuotaApplicationsForTemplateResponseBodyFailResults : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
