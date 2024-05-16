// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillPredictionRequest : TeaModel {
        /// <summary>
        /// The billable region. Valid values:
        /// 
        /// *   **CN**: the Chinese mainland
        /// *   **OverSeas**: outside the Chinese mainland
        /// *   **AP1**: Asia Pacific 1
        /// *   **AP2**: Asia Pacific 2
        /// *   **AP3**: Asia Pacific 3
        /// *   **NA**: North America
        /// *   **SA**: South America
        /// *   **EU**: Europe
        /// *   **MEAA**: Middle East and Africa
        /// 
        /// By default, the value of this parameter is determined by the metering method that is currently used. Regions inside and outside the Chinese mainland are classified into the **CN** and **OverSeas** billable regions. Billable regions inside the Chinese mainland include **CN**. Billable regions outside the Chinese mainland include **AP1**, **AP2**, **AP3**, **NA**, **SA**, **EU**, and **MEAA**.
        /// 
        /// > For more information about billable regions, see [Billable regions](https://help.aliyun.com/document_detail/142221.html).
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The billable item. A value of flow specifies bandwidth.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// The end time of the estimation. The default value is the current time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The start time of the estimation. The default value is 00:00 on the first day of the current month. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
