// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvServiceMonitorResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvServiceMonitorResponseBodyData Data { get; set; }
        public class DescribeEnvServiceMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The YAML configuration file of the ServiceMonitor.
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// The ID of the environment instance.
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the ServiceMonitor.
            /// </summary>
            [NameInMap("ServiceMonitorName")]
            [Validation(Required=false)]
            public string ServiceMonitorName { get; set; }

            /// <summary>
            /// The status. Valid values:
            /// 
            /// *   run
            /// *   stop
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
