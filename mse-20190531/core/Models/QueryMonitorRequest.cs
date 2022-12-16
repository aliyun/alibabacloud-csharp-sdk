// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryMonitorRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The timestamp when the monitoring ends.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metric type. The following metrics are supported:
        /// 
        /// \[Basic system metrics]
        /// 
        /// *   cpuUsage
        /// *   memoryUsage
        /// *   diskUsage
        /// *   gcCount
        /// *   gcTime
        /// 
        /// \[Nacos registry]
        /// 
        /// *   serviceCount
        /// *   writeCostTime
        /// *   readCostTime
        /// *   regCenterTps
        /// *   regCenterQps
        /// 
        /// \[Nacos configuration center]
        /// 
        /// *   publish
        /// *   getConfig
        /// 
        /// \[Zookeeper]
        /// 
        /// *   zk_TpsCount
        /// *   zk_QpsCount
        /// *   zookeeper_AvgRequestLatency
        /// </summary>
        [NameInMap("MonitorType")]
        [Validation(Required=false)]
        public string MonitorType { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// The timestamp when the monitoring starts.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The interval between data points. Unit: seconds.
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

    }

}
