// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the Cloud Monitor agent is automatically installed on existing Elastic Compute Service (ECS) instances. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// The status code.
        /// 
        /// >  The status code 200 indicates a success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The service for which one-click alert is enabled.
        /// </summary>
        [NameInMap("EnableActiveAlert")]
        [Validation(Required=false)]
        public string EnableActiveAlert { get; set; }

        /// <summary>
        /// Indicates whether the Cloud Monitor agent is automatically installed on new ECS instances. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableInstallAgentNewECS")]
        [Validation(Required=false)]
        public bool? EnableInstallAgentNewECS { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation was successful. Valid values:
        /// 
        /// *   true: successful.
        /// *   false: failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
