// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDriverConfigsResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("DriverConfigList")]
        [Validation(Required=false)]
        public List<BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigList> DriverConfigList { get; set; }
        public class BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigList : TeaModel {
            /// <summary>
            /// The configuration information of the driver.
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigListConfigList> ConfigList { get; set; }
            public class BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigListConfigList : TeaModel {
                /// <summary>
                /// The ID of the configuration.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// The configuration content or the Object Storage Service (OSS) path of the configuration file.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The format of the configuration. Valid values: KV (key-value pair), JSON (JSON string), and FILE (configuration file).
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The key of the configuration. If multiple configurations are available, keywords can be used to identify the configurations.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// The ID of the driver.
            /// </summary>
            [NameInMap("DriverId")]
            [Validation(Required=false)]
            public string DriverId { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
