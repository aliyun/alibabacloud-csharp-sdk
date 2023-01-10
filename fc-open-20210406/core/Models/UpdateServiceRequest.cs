// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// The description of the service.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to allow functions to access the Internet. Valid values:
        /// 
        /// *   **true**: allows functions in the specified service to access the Internet.
        /// *   **false**: does not allow functions in the specified service to access the Internet.
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// The log configuration. Function Compute writes function execution logs to the specified Logstore.
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// The configurations of the NAS file system. The configurations allow functions to access the specified NAS resources.
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// The OSS mount configurations.
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// The RAM role that is used to grant required permissions to Function Compute. The RAM role is used in the following scenarios:
        /// 
        /// *   Sends function execution logs to your Logstore.
        /// *   Generates a token for a function to access other cloud resources during function execution.
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The configurations of Tracing Analysis. After you configure Tracing Analysis for a service in Function Compute, you can record the execution duration of a request, view the amount of cold start time for a function, and record the execution duration of a function. For more information, see [Overview](~~189804~~).
        /// </summary>
        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) configuration, which allows functions in the specified service in Function Compute to access the specified VPC.
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
