// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotSuspStatisticsRequest : TeaModel {
        /// <summary>
        /// The source of the request. Set the value to **honeypot**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The time range of the data to query. Unit: days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StatisticsDays")]
        [Validation(Required=false)]
        public int? StatisticsDays { get; set; }

        /// <summary>
        /// The type of the asset to query. Valid values:
        /// 
        /// *   **vpcInstanceId**: VPC
        /// *   **uuid**: server
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StatisticsKeyType")]
        [Validation(Required=false)]
        public string StatisticsKeyType { get; set; }

    }

}
