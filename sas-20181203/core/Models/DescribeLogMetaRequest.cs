// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogMetaRequest : TeaModel {
        /// <summary>
        /// The topic of logs that are delivered.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The category of logs. Valid values:
        /// 
        /// *   **host**: host logs
        /// *   **network**: network logs
        /// *   **security**: security logs
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the request source. Default value: **aegis**. Valid values:
        /// 
        /// *   **aegis**: Server Guard
        /// *   **sas**: Security Center
        /// 
        /// >  If you use Server Guard, set the value to **aegis**. If you use Security Center, set the value to **sas**.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
