// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohSubDomainStatisticsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the YYYY-MM-DD format.
        /// 
        /// The default value is the day when you perform the operation.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the YYYY-MM-DD format.
        /// 
        /// You can query only the DNS records of the latest 90 days. `The value of StartDate must be greater than or equal to the difference between the current date and 90`.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The subdomain whose statistics you want to query.
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

    }

}
