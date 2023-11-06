// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigurationRecorderResponseBody : TeaModel {
        /// <summary>
        /// The details of the configuration recorder.
        /// </summary>
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public StartConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class StartConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            /// <summary>
            /// The status of the configuration recorder. Valid values:
            /// 
            /// *   REGISTRABLE: The configuration recorder has not been registered.
            /// *   BUILDING: The configuration recorder is being deployed.
            /// *   REGISTERED: The configuration recorder has been registered.
            /// *   REBUILDING: The configuration recorder is being redeployed.
            /// </summary>
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }

            /// <summary>
            /// The types of the resources that are monitored by Cloud Config.
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
