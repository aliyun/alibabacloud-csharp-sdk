// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerResponseBody : TeaModel {
        /// <summary>
        /// The Function Compute triggers that are set for Alibaba Cloud CDN events.
        /// </summary>
        [NameInMap("FCTriggers")]
        [Validation(Required=false)]
        public List<ListFCTriggerResponseBodyFCTriggers> FCTriggers { get; set; }
        public class ListFCTriggerResponseBodyFCTriggers : TeaModel {
            /// <summary>
            /// The name of the event.
            /// </summary>
            [NameInMap("EventMetaName")]
            [Validation(Required=false)]
            public string EventMetaName { get; set; }

            /// <summary>
            /// The version of the event.
            /// </summary>
            [NameInMap("EventMetaVersion")]
            [Validation(Required=false)]
            public string EventMetaVersion { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public string Notes { get; set; }

            /// <summary>
            /// The Resource Access Management (RAM) role.
            /// </summary>
            [NameInMap("RoleARN")]
            [Validation(Required=false)]
            public string RoleARN { get; set; }

            /// <summary>
            /// The resources and filters for event listening.
            /// </summary>
            [NameInMap("SourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

            /// <summary>
            /// The trigger that corresponds to the Function Compute service.
            /// </summary>
            [NameInMap("TriggerARN")]
            [Validation(Required=false)]
            public string TriggerARN { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
