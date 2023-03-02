// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateConfigRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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
        /// The ID of the instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable RAM authorization for a configuration center. This parameter is valid for Nacos instances. Valid values:
        /// 
        /// *   `true`: enabled
        /// *   `false`: disabled
        /// 
        /// > Before you configure this parameter, you must call the QueryConfig operation to obtain the ConfigAuthSupported parameter value to check whether the instance supports this feature.
        /// </summary>
        [NameInMap("ConfigAuthEnabled")]
        [Validation(Required=false)]
        public bool? ConfigAuthEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable configuration encryption for a configuration center. This parameter is valid for Nacos instances. Valid values:
        /// 
        /// *   `true`: enabled
        /// *   `false`: disabled
        /// 
        /// > Before you configure this parameter, you must call the QueryConfig operation to obtain the ConfigSecretSupported parameter value to check whether the instance supports this feature.
        /// </summary>
        [NameInMap("ConfigSecretEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSecretEnabled { get; set; }

        /// <summary>
        /// The format of the configuration. Supported formats include TEXT, JSON, XML, and HTML.
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("EurekaSupported")]
        [Validation(Required=false)]
        public bool? EurekaSupported { get; set; }

        /// <summary>
        /// Specifies whether to enable the time to live (TTL) configuration.
        /// </summary>
        [NameInMap("ExtendedTypesEnable")]
        [Validation(Required=false)]
        public string ExtendedTypesEnable { get; set; }

        /// <summary>
        /// The maximum connection duration of the instance. This parameter is valid for ZooKeeper instances. Unit: seconds.
        /// </summary>
        [NameInMap("InitLimit")]
        [Validation(Required=false)]
        public string InitLimit { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum amount of data on each node. This parameter is valid for ZooKeeper instances. The default maximum data amount on each node is 1 megabyte. Unit: bytes.
        /// </summary>
        [NameInMap("JuteMaxbuffer")]
        [Validation(Required=false)]
        public string JuteMaxbuffer { get; set; }

        /// <summary>
        /// Specifies whether to enable Mesh Configuration Protocol (MCP). This parameter is valid for Nacos instances. Valid values:
        /// 
        /// *   `true`: enabled
        /// *   `false`: disabled
        /// 
        /// > Before you configure this parameter, you must call the QueryConfig operation to obtain the MCPSupported parameter value to check whether the instance supports this feature.
        /// </summary>
        [NameInMap("MCPEnabled")]
        [Validation(Required=false)]
        public bool? MCPEnabled { get; set; }

        /// <summary>
        /// The number of connections between a client and a server. This parameter is valid for ZooKeeper instances.\
        /// If this parameter is set to 0, no limits are imposed on the number of connections.
        /// </summary>
        [NameInMap("MaxClientCnxns")]
        [Validation(Required=false)]
        public string MaxClientCnxns { get; set; }

        /// <summary>
        /// The maximum timeout period. This parameter is valid for ZooKeeper instances. Unit: seconds.
        /// </summary>
        [NameInMap("MaxSessionTimeout")]
        [Validation(Required=false)]
        public string MaxSessionTimeout { get; set; }

        /// <summary>
        /// The minimum timeout period. This parameter is valid for ZooKeeper instances. Unit: seconds.
        /// </summary>
        [NameInMap("MinSessionTimeout")]
        [Validation(Required=false)]
        public string MinSessionTimeout { get; set; }

        /// <summary>
        /// Specifies whether to enable RAM authorization for a registry. This parameter is valid for Nacos instances. Valid values:
        /// 
        /// *   `true`: enabled
        /// *   `false`: disabled
        /// 
        /// > Before you configure this parameter, you must call the QueryConfig operation to obtain the NamingAuthSupporte parameter value to check whether the instance supports this feature.
        /// </summary>
        [NameInMap("NamingAuthEnabled")]
        [Validation(Required=false)]
        public bool? NamingAuthEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable super permissions. This parameter is valid for ZooKeeper instances. Valid values:
        /// 
        /// *   `true`: enabled
        /// *   `false`: disabled
        /// </summary>
        [NameInMap("OpenSuperAcl")]
        [Validation(Required=false)]
        public string OpenSuperAcl { get; set; }

        /// <summary>
        /// The password that corresponds to the username.
        /// 
        /// > You must specify this parameter if OpenSuperAcl is set to true.
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

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
        /// The time unit. This parameter is valid for ZooKeeper instances. Default value: 2000. Unit: milliseconds.
        /// </summary>
        [NameInMap("TickTime")]
        [Validation(Required=false)]
        public string TickTime { get; set; }

        /// <summary>
        /// The name of the user.
        /// 
        /// > You must specify this parameter if OpenSuperAcl is set to true.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
