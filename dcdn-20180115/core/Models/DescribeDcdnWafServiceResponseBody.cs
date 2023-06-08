// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafServiceResponseBody : TeaModel {
        /// <summary>
        /// The edition of WAF.
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The status of WAF. Valid values:
        /// 
        /// *   on
        /// *   off
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// The time when WAF was enabled.
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// The metering method for requests.
        /// </summary>
        [NameInMap("RequestBillingType")]
        [Validation(Required=false)]
        public string RequestBillingType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The metering method for rules. You are charged for the number of SeCUs.
        /// </summary>
        [NameInMap("RuleBillingType")]
        [Validation(Required=false)]
        public string RuleBillingType { get; set; }

        /// <summary>
        /// The status of WAF. Valid values:
        /// 
        /// *   Normal
        /// *   WaitForExpire
        /// *   Expired
        /// *   Released
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
