// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsResponseBody : TeaModel {
        /// <summary>
        /// Code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPluginsResponseBodyData> Data { get; set; }
        public class GetPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// The directory of the plug-in.
            /// 
            /// 0: user-defined
            /// 
            /// 1: permission authentication
            /// 
            /// 2: security protection
            /// 
            /// 3: transmission protocol
            /// 
            /// 4: traffic control
            /// 
            /// 5: traffic observation
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// The information about the configuration check.
            /// </summary>
            [NameInMap("ConfigCheck")]
            [Validation(Required=false)]
            public string ConfigCheck { get; set; }

            /// <summary>
            /// The ID of the plug-in.
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
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NewVersionPublishingFlag")]
            [Validation(Required=false)]
            public bool? NewVersionPublishingFlag { get; set; }

            /// <summary>
            /// The plug-in execution stage.
            /// 
            /// *   0: default stage
            /// *   1: authorization stage
            /// *   2: authentication stage
            /// *   3: statistics stage
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            /// <summary>
            /// The ID of the creator.
            /// </summary>
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            /// <summary>
            /// The plug-in execution priority. A larger value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The publish status.
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public int? PublishState { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is enabled.
            /// 
            /// *   0: disabled
            /// *   1: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The summary of the plug-in.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The Object Storage Service (OSS) of the WebAssembly plug-in.
            /// </summary>
            [NameInMap("WasmFile")]
            [Validation(Required=false)]
            public string WasmFile { get; set; }

            /// <summary>
            /// The WebAssembly language.
            /// 
            /// *   0: C++
            /// *   1: TinyGo
            /// *   2: Rust
            /// *   3: AssemblyScript
            /// *   4: Zig
            /// </summary>
            [NameInMap("WasmLang")]
            [Validation(Required=false)]
            public int? WasmLang { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
