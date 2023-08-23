// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListEventCenterRecordRequest : TeaModel {
        /// <summary>
        /// The type of the event. Valid values:
        /// 
        /// *   `cr:Artifact:DeliveryChainCompleted`: The delivery chain is processed.
        /// *   `cr:Artifact:SynchronizationCompleted`: The image is replicated.
        /// *   `cr:Artifact:BuildCompleted`: The image is built.
        /// *   `cr:Artifact:ScanCompleted`: The image is scanned.
        /// *   `cr:Artifact:SigningCompleted`: The image is signed.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the event notification rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
