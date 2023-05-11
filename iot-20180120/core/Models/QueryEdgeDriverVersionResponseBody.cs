// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeDriverVersionResponseBodyData Data { get; set; }
        public class QueryEdgeDriverVersionResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The information about each version of the driver.
            /// </summary>
            [NameInMap("DriverVersionList")]
            [Validation(Required=false)]
            public List<QueryEdgeDriverVersionResponseBodyDataDriverVersionList> DriverVersionList { get; set; }
            public class QueryEdgeDriverVersionResponseBodyDataDriverVersionList : TeaModel {
                /// <summary>
                /// The Java Virtual Machine (JVM) startup parameter.
                /// </summary>
                [NameInMap("Argument")]
                [Validation(Required=false)]
                public string Argument { get; set; }

                /// <summary>
                /// The rule for verifying configurations. The value is a JSON string in the following format:
                /// 
                /// `{"deviceConfig":{"required":false},"driverConfig":{"required":false}`
                /// 
                /// The JSON string contains the following parameters:
                /// 
                /// *   driverConfig: the rule for verifying the configuration of the driver when the driver is to be deployed in an edge instance.
                /// *   deviceConfig: the rule for verifying the configurations of devices that use the driver when the driver is to be deployed in an edge instance.
                /// </summary>
                [NameInMap("ConfigCheckRule")]
                [Validation(Required=false)]
                public string ConfigCheckRule { get; set; }

                /// <summary>
                /// The configuration of the container where the driver runs. The value is a JSON string. For more information about parameters in the JSON string, see the following parameter description of ContainerConfig.
                /// </summary>
                [NameInMap("ContainerConfig")]
                [Validation(Required=false)]
                public string ContainerConfig { get; set; }

                /// <summary>
                /// The description of the driver.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The configuration of the driver. The value is a JSON string in the following format:
                /// 
                /// `{"format":"JSON","content":"{}"}`
                /// 
                /// The JSON string contains the following parameters:
                /// 
                /// *   format: the format of the driver configuration. Valid values: KV (key-value pair), JSON (JSON string), and FILE (configuration file).
                /// *   content: the content of the driver configuration. If the format parameter is set to KV or JSON, the value of this parameter is the configuration content. If the format parameter is set to FILE, the value of this parameter is the URL of the configuration file stored in Object Storage Service (OSS).
                /// </summary>
                [NameInMap("DriverConfig")]
                [Validation(Required=false)]
                public string DriverConfig { get; set; }

                /// <summary>
                /// The ID of the driver.
                /// </summary>
                [NameInMap("DriverId")]
                [Validation(Required=false)]
                public string DriverId { get; set; }

                /// <summary>
                /// The version number of the driver.
                /// </summary>
                [NameInMap("DriverVersion")]
                [Validation(Required=false)]
                public string DriverVersion { get; set; }

                /// <summary>
                /// The earliest version of Link IoT Edge that is supported by the driver.
                /// </summary>
                [NameInMap("EdgeVersion")]
                [Validation(Required=false)]
                public string EdgeVersion { get; set; }

                /// <summary>
                /// The UNIX timestamp when the driver was created.
                /// </summary>
                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                /// <summary>
                /// The last UNIX timestamp when the driver was updated.
                /// </summary>
                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("SourceConfig")]
                [Validation(Required=false)]
                public string SourceConfig { get; set; }

                /// <summary>
                /// The status of the driver version. Valid values:
                /// 
                /// *   0: The driver version was not published.
                /// *   1: The driver version was published.
                /// </summary>
                [NameInMap("VersionState")]
                [Validation(Required=false)]
                public string VersionState { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of driver versions.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
