// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateApplicationMonitorRequest : TeaModel {
        /// <summary>
        /// The URL or IP address that you want to probe.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable the automatic diagnostics feature. Default value: false. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("DetectEnable")]
        [Validation(Required=false)]
        public bool? DetectEnable { get; set; }

        /// <summary>
        /// Set the threshold that is used to trigger the automatic diagnostics feature. If the liveness of the origin in percentile drops below the specified threshold, the automatic diagnostics feature is triggered.
        /// 
        /// Valid values: **0** to **100**.
        /// </summary>
        [NameInMap("DetectThreshold")]
        [Validation(Required=false)]
        public int? DetectThreshold { get; set; }

        /// <summary>
        /// The number of times that are required to reach the threshold before the automatic diagnostics feature can be triggered.
        /// 
        /// Valid values: **1** to **20**.
        /// </summary>
        [NameInMap("DetectTimes")]
        [Validation(Required=false)]
        public int? DetectTimes { get; set; }

        /// <summary>
        /// The ID of the listener that you want to modify. The listener runs the origin probing task.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The extended options of the listener protocol that is used by the origin probing task. The options vary based on the listener protocol.
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The silence period of the automatic diagnostics feature. This parameter specifies the interval at which the automatic diagnostics feature is triggered. If the availability rate does not return to normal after GA triggers an automatic diagnostic, GA must wait until the silence period ends before GA can trigger another automatic diagnostic.
        /// 
        /// If the number of consecutive times that the availability rate drops below the threshold of automatic diagnostics reaches the value of the **DetectTimes** parameter, the automatic diagnostics feature is triggered. The automatic diagnostics feature is not triggered again within the silence period even if the availability rate stays below the threshold. If the availability rate does not return to normal after the silence period ends, the automatic diagnostics feature is triggered again.
        /// 
        /// Unit: seconds. Valid values: **300** to **86400**.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The ID of the origin probing task that you want to modify.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The name of the origin probing task.
        /// 
        /// The name must be 4 to 100 characters in length, and can contain digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
