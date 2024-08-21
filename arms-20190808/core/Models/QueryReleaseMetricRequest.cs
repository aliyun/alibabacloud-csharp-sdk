// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryReleaseMetricRequest : TeaModel {
        /// <summary>
        /// The ID of the change order.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// The time when the change order was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The type of the metric that you want to query.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// The ID of the Enterprise Distributed Application Service (EDAS) or Kubernetes application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// This parameter is not in use.
        /// </summary>
        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        /// <summary>
        /// The end time of the version release.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseEndTime")]
        [Validation(Required=false)]
        public long? ReleaseEndTime { get; set; }

        /// <summary>
        /// The start time of the version release.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseStartTime")]
        [Validation(Required=false)]
        public long? ReleaseStartTime { get; set; }

        /// <summary>
        /// The service that you want to query.
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
