// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAlarmEventsRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Default value: **100**
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The risk levels of the alert events.
        /// </summary>
        [NameInMap("DstIp")]
        [Validation(Required=false)]
        public string DstIp { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The risk level. Valid values:
        /// 
        /// *   **2**: low
        /// *   **3**: medium
        /// *   **4**: high
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// The destination IP address.
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

    }

}
