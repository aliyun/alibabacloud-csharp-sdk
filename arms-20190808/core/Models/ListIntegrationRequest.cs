// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListIntegrationRequest : TeaModel {
        /// <summary>
        /// The name of the alert integration.
        /// </summary>
        [NameInMap("IntegrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// The type of the alert integration. Valid values:
        /// 
        /// *   CLOUD_MONITOR: CloudMonitor
        /// *   LOG_SERVICE: Log Service
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntegrationProductType")]
        [Validation(Required=false)]
        public string IntegrationProductType { get; set; }

        /// <summary>
        /// Specifies whether to display the details of each alert integration:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The number of alert integrations to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
