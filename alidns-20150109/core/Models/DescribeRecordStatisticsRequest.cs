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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The type of the domain name. The parameter value is not case-sensitive. Valid values:
        /// 
        /// *   PUBLIC (default): hosted public domain name
        /// *   CACHE: cache-accelerated domain name
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The end date of the query. Specify the end date in the **YYYY-MM-DD** format.
        /// 
        /// The default value is the day when you query the data.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The hostname. If you want to resolve the subdomain name www.dns-exmaple.top, set this parameter to www.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// The start date of the query. Specify the start date in the **YYYY-MM-DD** format.
        /// 
        /// You can only query the DNS records within the last 90 days.``
        /// 
        /// If the time range is less than or equal to seven days, data is returned on an hourly basis.````
        /// 
        /// If the time range is greater than seven days, data is returned on a daily basis.````
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
