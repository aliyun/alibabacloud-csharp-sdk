// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the **YYYY-MM-DD** format.
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
        /// The DNS record.
        /// 
        /// The host record. For example, to resolve `www.dns-exmaple.com`, you must set Rr to www.
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the **YYYY-MM-DD** format.
        /// 
        /// You can only query DNS records of the last 90 days.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
