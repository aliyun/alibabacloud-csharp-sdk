// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ApplyScenarioShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The configuration of the business monitoring job. The value is a JSON string. For more information about this parameter, see the following additional information about the **Config** parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        /// <summary>
        /// The name of the business monitoring job.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The scenario where you want to use the business monitoring job. Valid values:
        /// 
        /// *   `USER-DEFINED`: user-defined. This is the default value.
        /// *   `EDAS-ROLLOUT`: application release in Enterprise Distributed Application Service (EDAS)
        /// *   `OAM-ROLLOUT`: application release based on Open Application Model (OAM)
        /// *   `MSC-CANARY`: canary release based on Microservice Engine (MSE)
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// The code of the business monitoring job. This parameter is not required when you create a business monitoring job. However, this parameter is required when you update a business monitoring job.
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        /// <summary>
        /// Specifies whether to record business parameters to the trace marked with the coloring sign.
        /// 
        /// *   `true`
        /// *   `false`: This is the default value.
        /// </summary>
        [NameInMap("SnDump")]
        [Validation(Required=false)]
        public bool? SnDump { get; set; }

        /// <summary>
        /// Specifies whether traffic in the trace marked with the coloring sign is all collected.
        /// 
        /// *   `true`
        /// *   `false`: This is the default value.
        /// </summary>
        [NameInMap("SnForce")]
        [Validation(Required=false)]
        public bool? SnForce { get; set; }

        /// <summary>
        /// Specifies whether to count traffic based on the coloring sign.
        /// 
        /// *   `true`
        /// *   `false`: This is the default value.
        /// </summary>
        [NameInMap("SnStat")]
        [Validation(Required=false)]
        public bool? SnStat { get; set; }

        /// <summary>
        /// Specifies whether the coloring sign is transparently passed down to downstream application nodes in the trace.
        /// 
        /// *   `true`
        /// *   `false`: This is the default value.
        /// </summary>
        [NameInMap("SnTransfer")]
        [Validation(Required=false)]
        public bool? SnTransfer { get; set; }

        /// <summary>
        /// Specifies whether the operation is an update operation.
        /// 
        /// *   `true`: update
        /// *   `false`: insert
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public bool? UpdateOption { get; set; }

    }

}
