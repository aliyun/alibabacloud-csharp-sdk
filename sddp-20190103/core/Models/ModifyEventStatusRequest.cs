// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyEventStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enhance the detection of anomalous events. If you enhance the detection of anomalous events, the detection accuracy and the rate of triggering alerts for anomalous events are improved. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Backed")]
        [Validation(Required=false)]
        public bool? Backed { get; set; }

        /// <summary>
        /// The reason why the anomalous event is handled.
        /// </summary>
        [NameInMap("DealReason")]
        [Validation(Required=false)]
        public string DealReason { get; set; }

        /// <summary>
        /// The ID of the anomalous event.
        /// 
        /// > You can call the **DescribeEvents** operation to query the ID of the anomalous event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The method to handle the anomalous event. Valid values:
        /// 
        /// *   **1**: marks the anomalous event as a false positive.
        /// *   **2**: confirms and handles the anomalous event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
