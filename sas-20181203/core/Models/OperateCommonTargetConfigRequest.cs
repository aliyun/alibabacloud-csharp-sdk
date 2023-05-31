// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonTargetConfigRequest : TeaModel {
        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   **repoName**: the name of the image repository
        /// *   **repoNamespace**: the namespace of the image repository
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// The name of the image repository or the namespace of the image repository.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The configuration of proactive defense for your server. The value includes the following fields:
        /// 
        /// *   **targetType**: specifies the dimension from which you manage proactive defense. UUIDs are supported. Set the value to **uuid**.
        /// *   **target**: specifies the UUID of the server for which you want to configure proactive defense.
        /// *   **flag**: specifies whether to enable or disable proactive defense for your server. Valid values are **add** and **del**. The value add indicates that proactive defense will be enabled for your server. The value del indicates that proactive defense will be disabled for your server.
        /// </summary>
        [NameInMap("TargetOperations")]
        [Validation(Required=false)]
        public string TargetOperations { get; set; }

        /// <summary>
        /// The dimension based on which you want to configure the feature. Valid values:
        /// 
        /// *   **uuid**: the UUID of the server
        /// *   **Cluster**: the ID of the cluster
        /// *   **image_repo**: the name of the image repository
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   **alidetect-scan-enable**: local file detection
        /// *   **ACTION-TRIAL-PERMISSION**: data delivery of ActionTrail
        /// *   **alidetect**: local file detection engine
        /// *   **container\_prevent\_escape**: container escape prevention
        /// *   **image\_repo**: repository image scan
        /// *   **proc\_filter\_switch**: log filtering
        /// *   **agentless**: agentless detection
        /// *   **rasp**: application protection
        /// *   **sensitiveFile**: sensitive file detection
        /// *   **aliscriptengine**: in-depth detection engine
        /// *   **containerNetwork**: container network visualization
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
