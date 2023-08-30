// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the plug-in.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPluginsResponseBodyData> Data { get; set; }
        public class GetPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// \# The configuration includes the fields required for checking, such as name, age, and friends. Sample configuration: name: John age: 18 friends: - David - Anne
            /// </summary>
            [NameInMap("ConfigCheck")]
            [Validation(Required=false)]
            public string ConfigCheck { get; set; }

            /// <summary>
            /// The ID of the creator.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MaxVersion")]
            [Validation(Required=false)]
            public string MaxVersion { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NewVersionPublishingFlag")]
            [Validation(Required=false)]
            public bool? NewVersionPublishingFlag { get; set; }

            /// <summary>
            /// The execution priority of the plug-in. A larger value indicates a higher priority.
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            /// <summary>
            /// The type of the plug-in. Valid values:
            /// 
            /// 0: custom
            /// 
            /// 1: permission authorization
            /// 
            /// 2: security protection
            /// 
            /// 3: transmission protocol
            /// 
            /// 4: traffic control
            /// 
            /// 5: traffic observation
            /// </summary>
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            /// <summary>
            /// The information about the plug-in configuration used for checking.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The URL of the Object Storage Service (OSS) bucket that stores the WebAssembly plug-in.
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public int? PublishState { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This is a plug-in.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// The summary of the plug-in.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is enabled.
            /// 
            /// *   0: disabled
            /// *   1: enabled
            /// </summary>
            [NameInMap("WasmFile")]
            [Validation(Required=false)]
            public string WasmFile { get; set; }

            /// <summary>
            /// The publish status.
            /// </summary>
            [NameInMap("WasmLang")]
            [Validation(Required=false)]
            public int? WasmLang { get; set; }

        }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The data entries returned.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The dynamic part in the error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned code.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
