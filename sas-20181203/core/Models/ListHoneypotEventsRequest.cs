// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventsRequest : TeaModel {
        /// <summary>
        /// The probe IDs.
        /// </summary>
        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public List<string> AgentIdList { get; set; }

        /// <summary>
        /// The ID of the alert.
        /// </summary>
        [NameInMap("AlarmEventId")]
        [Validation(Required=false)]
        public long? AlarmEventId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The status of the event. Valid values:
        /// 
        /// *   **y**: handled
        /// *   **n**: unhandled
        /// *   **a**: all statuses
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The honeypot IDs.
        /// </summary>
        [NameInMap("HoneypotIdList")]
        [Validation(Required=false)]
        public List<string> HoneypotIdList { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the attacker profile.
        /// </summary>
        [NameInMap("PortraitId")]
        [Validation(Required=false)]
        public string PortraitId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The risk levels.
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// The source IP address of the attack.
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

    }

}
