// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the request source. Set the value to **sas**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The timestamp of the detection. Unit: milliseconds.
        /// </summary>
        [NameInMap("IncidentTime")]
        [Validation(Required=false)]
        public long? IncidentTime { get; set; }

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
        /// The source IP address of the request. The value of this parameter is specified by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the vertex. Set the value to **SAS_INCIDENT**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The ID of the vertex. You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

    }

}
