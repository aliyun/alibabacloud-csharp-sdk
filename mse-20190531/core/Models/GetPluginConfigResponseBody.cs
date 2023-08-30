// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginConfigResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPluginConfigResponseBodyData Data { get; set; }
        public class GetPluginConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The category of the plug-in. Valid values:
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
            /// The information about the plug-in configuration used for checking.
            /// </summary>
            [NameInMap("ConfigCheck")]
            [Validation(Required=false)]
            public string ConfigCheck { get; set; }

            /// <summary>
            /// The list of gateway plug-in configurations.
            /// </summary>
            [NameInMap("GatewayConfigList")]
            [Validation(Required=false)]
            public List<GetPluginConfigResponseBodyDataGatewayConfigList> GatewayConfigList { get; set; }
            public class GetPluginConfigResponseBodyDataGatewayConfigList : TeaModel {
                /// <summary>
                /// The plug-in configuration.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The application scope of the plug-in. Valid values:
                /// 
                /// 0: global
                /// 
                /// 1: domain names
                /// 
                /// 2: routes
                /// </summary>
                [NameInMap("ConfigLevel")]
                [Validation(Required=false)]
                public int? ConfigLevel { get; set; }

                /// <summary>
                /// Indicates whether the plug-in is enabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The ID of the gateway.
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// The unique ID of the gateway.
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the plug-in configuration.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the gateway plug-in.
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public long? PluginId { get; set; }

            }

            /// <summary>
            /// The ID of the plug-in.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The mode.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The execution stage of the plug-in. Valid values:
            /// 
            /// 0: default stage
            /// 
            /// 1: authorization stage
            /// 
            /// 2: authentication stage
            /// 
            /// 3: statistics stage
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
            /// The execution priority of the plug-in. A larger value indicates a higher priority.
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
            /// The description of the README file.
            /// </summary>
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            /// <summary>
            /// The description of the README file that is edited in English.
            /// </summary>
            [NameInMap("ReadmeEn")]
            [Validation(Required=false)]
            public string ReadmeEn { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is enabled. Valid values:
            /// 
            /// 0: disabled
            /// 
            /// 1: enabled
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
            /// The type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VersionJson")]
            [Validation(Required=false)]
            public string VersionJson { get; set; }

            /// <summary>
            /// The WebAssembly language. Valid values:
            /// 
            /// 0: C++
            /// 
            /// 1: TinyGo
            /// 
            /// 2: Rust
            /// 
            /// 3: AssemblyScript
            /// 
            /// 4: Zig
            /// </summary>
            [NameInMap("WasmLang")]
            [Validation(Required=false)]
            public int? WasmLang { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
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
        /// The error code returned if the request failed.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
