// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectReportRequest : TeaModel {
        /// <summary>
        /// The event ID that corresponds to the file to be detected.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// The field that you want to query. You can enter multiple fields and separate them with commas (,).
        /// 
        /// Valid values:
        /// 
        /// *   **ThreatTypes**: the type of the threat intelligence event
        /// *   **Intelligences**: the threat intelligence event
        /// *   **ThreatLevel**: the level of the threat intelligence event
        /// *   **Basic**: the basic information about the report (the scan result)
        /// *   **Sandbox**: the cloud sandbox check report
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The hash value of the file to be detected.
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The data source type. Valid values:
        /// 
        /// *   **machine**: host alerts
        /// *   **object_scan**: file detection alerts
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
