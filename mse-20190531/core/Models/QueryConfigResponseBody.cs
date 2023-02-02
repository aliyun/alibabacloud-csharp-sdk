// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryConfigResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConfigResponseBodyData Data { get; set; }
        public class QueryConfigResponseBodyData : TeaModel {
            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("AutopurgePurgeInterval")]
            [Validation(Required=false)]
            public string AutopurgePurgeInterval { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("AutopurgeSnapRetainCount")]
            [Validation(Required=false)]
            public string AutopurgeSnapRetainCount { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// Indicates whether RAM authorization of a configuration center is enabled. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("ConfigAuthEnabled")]
            [Validation(Required=false)]
            public bool? ConfigAuthEnabled { get; set; }

            /// <summary>
            /// Indicates whether RAM authorization is supported by a configuration center of the instance. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: supported
            /// *   `false`: not supported
            /// </summary>
            [NameInMap("ConfigAuthSupported")]
            [Validation(Required=false)]
            public bool? ConfigAuthSupported { get; set; }

            /// <summary>
            /// The maximum size of a configuration. Unit: KB.
            /// </summary>
            [NameInMap("ConfigContentLimit")]
            [Validation(Required=false)]
            public long? ConfigContentLimit { get; set; }

            /// <summary>
            /// Indicates whether configuration encryption of a configuration center is enabled by the instance. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("ConfigSecretEnabled")]
            [Validation(Required=false)]
            public bool? ConfigSecretEnabled { get; set; }

            /// <summary>
            /// Indicates whether configuration encryption of a configuration center is supported by the instance. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: supported
            /// *   `false`: not supported
            /// </summary>
            [NameInMap("ConfigSecretSupported")]
            [Validation(Required=false)]
            public bool? ConfigSecretSupported { get; set; }

            /// <summary>
            /// Indicates whether the time to live (TTL) configuration is enabled. This parameter is valid for ZooKeeper instances.
            /// </summary>
            [NameInMap("ExtendedTypesEnable")]
            [Validation(Required=false)]
            public bool? ExtendedTypesEnable { get; set; }

            /// <summary>
            /// The maximum connection duration of the instance. Unit: seconds. This parameter is valid for ZooKeeper instances.
            /// </summary>
            [NameInMap("InitLimit")]
            [Validation(Required=false)]
            public string InitLimit { get; set; }

            /// <summary>
            /// The maximum amount of data on each node. This parameter is valid for ZooKeeper instances. Unit: bytes.
            /// </summary>
            [NameInMap("JuteMaxbuffer")]
            [Validation(Required=false)]
            public string JuteMaxbuffer { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("JvmFlagsCustom")]
            [Validation(Required=false)]
            public string JvmFlagsCustom { get; set; }

            /// <summary>
            /// Indicates whether Mesh Configuration Protocol (MCP) is enabled. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("MCPEnabled")]
            [Validation(Required=false)]
            public bool? MCPEnabled { get; set; }

            /// <summary>
            /// Indicates whether MCP is supported. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: supported
            /// *   `false`: not supported
            /// </summary>
            [NameInMap("MCPSupported")]
            [Validation(Required=false)]
            public bool? MCPSupported { get; set; }

            /// <summary>
            /// The number of connections between a client and a server. This parameter is valid for ZooKeeper instances.\
            /// If this parameter is set to 0, no limits are imposed on the number of connections.
            /// </summary>
            [NameInMap("MaxClientCnxns")]
            [Validation(Required=false)]
            public string MaxClientCnxns { get; set; }

            /// <summary>
            /// The maximum timeout period. This parameter is valid for ZooKeeper instances.
            /// </summary>
            [NameInMap("MaxSessionTimeout")]
            [Validation(Required=false)]
            public string MaxSessionTimeout { get; set; }

            /// <summary>
            /// The minimum timeout period. This parameter is valid for ZooKeeper instances.
            /// </summary>
            [NameInMap("MinSessionTimeout")]
            [Validation(Required=false)]
            public string MinSessionTimeout { get; set; }

            /// <summary>
            /// The runtime configuration of the Nacos instance.
            /// </summary>
            [NameInMap("NacosRunningEnv")]
            [Validation(Required=false)]
            public QueryConfigResponseBodyDataNacosRunningEnv NacosRunningEnv { get; set; }
            public class QueryConfigResponseBodyDataNacosRunningEnv : TeaModel {
                /// <summary>
                /// Indicates whether empty list protection is enabled.
                /// </summary>
                [NameInMap("emptyProtect")]
                [Validation(Required=false)]
                public bool? EmptyProtect { get; set; }

            }

            /// <summary>
            /// Indicates whether RAM authorization of a registry is enabled. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("NamingAuthEnabled")]
            [Validation(Required=false)]
            public bool? NamingAuthEnabled { get; set; }

            /// <summary>
            /// Indicates whether RAM authorization of services is supported by the instance. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: supported
            /// *   `false`: not supported
            /// </summary>
            [NameInMap("NamingAuthSupported")]
            [Validation(Required=false)]
            public bool? NamingAuthSupported { get; set; }

            /// <summary>
            /// Indicates whether service creation is supported for the instance. This parameter is valid for Nacos instances. Valid values:
            /// 
            /// *   `true`: supported
            /// *   `false`: not supported
            /// </summary>
            [NameInMap("NamingCreateServiceSupported")]
            [Validation(Required=false)]
            public bool? NamingCreateServiceSupported { get; set; }

            /// <summary>
            /// Indicates whether super permissions are enabled. This parameter is valid for ZooKeeper instances. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("OpenSuperAcl")]
            [Validation(Required=false)]
            public bool? OpenSuperAcl { get; set; }

            /// <summary>
            /// The user password. This parameter is valid only if OpenSuperAcl is set to true.
            /// </summary>
            [NameInMap("PassWord")]
            [Validation(Required=false)]
            public string PassWord { get; set; }

            /// <summary>
            /// Indicates whether the instance was restarted and new configurations have taken effect. Valid values:
            /// 
            /// *   `true`: The restart was successful.
            /// *   `false`: The restart failed.
            /// </summary>
            [NameInMap("RestartFlag")]
            [Validation(Required=false)]
            public bool? RestartFlag { get; set; }

            /// <summary>
            /// The frequency for generating snapshots. This parameter is valid for ZooKeeper instances.
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public string SnapshotCount { get; set; }

            /// <summary>
            /// The connection timeout period of the instance. This parameter is valid for ZooKeeper instances. Unit: seconds.
            /// </summary>
            [NameInMap("SyncLimit")]
            [Validation(Required=false)]
            public string SyncLimit { get; set; }

            /// <summary>
            /// The time unit of the engine. This parameter is valid for ZooKeeper instances. Default value: 2000. Unit: milliseconds.
            /// </summary>
            [NameInMap("TickTime")]
            [Validation(Required=false)]
            public string TickTime { get; set; }

            /// <summary>
            /// The username. This parameter is valid only if OpenSuperAcl is set to true.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
