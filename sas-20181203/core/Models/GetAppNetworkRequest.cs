// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster to which the container belongs.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The end timestamp of the query. Unit: milliseconds.
        /// 
        /// > The days between the start timestamp and the end timestamp cannot exceed **seven** days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The start timestamp of the query. Unit: milliseconds.
        /// 
        /// > The days between the start timestamp and the end timestamp cannot exceed **seven** days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
