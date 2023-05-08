// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateContainerScanTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster to which the container belongs.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the container.
        /// </summary>
        [NameInMap("ContainerIds")]
        [Validation(Required=false)]
        public string ContainerIds { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
