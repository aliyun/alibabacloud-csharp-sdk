// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppEventsRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The type of the event. Valid values:
        /// 
        /// *   **Warning**: an alert.
        /// *   **Normal**: a normal event.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The namespace ID.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The type of the object. Valid values:
        /// 
        /// *   **Deployment**: an application.
        /// *   **Pod**: an application instance.
        /// *   **Service**: a Server Load Balancer (SLB) instance.
        /// *   **HorizontalPodAutoscaler**: an auto scaling policy.
        /// *   **CloneSet**: an application.
        /// </summary>
        [NameInMap("ObjectKind")]
        [Validation(Required=false)]
        public string ObjectKind { get; set; }

        /// <summary>
        /// The name of the object. Fuzzy search by prefix is supported.
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 0 to 10000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The cause of the event. Fuzzy search by prefix is supported.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
