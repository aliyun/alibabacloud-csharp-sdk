// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConfigResponseBodyData Data { get; set; }
        public class QueryConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The switch for ZooKeeper SASL-based forced identity authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthEnabled")]
            [Validation(Required=false)]
            public bool? AuthEnabled { get; set; }

            /// <summary>
            /// <para>A reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AutopurgePurgeInterval")]
            [Validation(Required=false)]
            public string AutopurgePurgeInterval { get; set; }

            /// <summary>
            /// <para>A reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AutopurgeSnapRetainCount")]
            [Validation(Required=false)]
            public string AutopurgeSnapRetainCount { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether RAM authentication is enabled for the configuration center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigAuthEnabled")]
            [Validation(Required=false)]
            public bool? ConfigAuthEnabled { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether the configuration center of the current cluster supports RAM authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: supported</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigAuthSupported")]
            [Validation(Required=false)]
            public bool? ConfigAuthSupported { get; set; }

            /// <summary>
            /// <para>The maximum size of the content of a single configuration. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ConfigContentLimit")]
            [Validation(Required=false)]
            public long? ConfigContentLimit { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether configuration encryption is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigSecretEnabled")]
            [Validation(Required=false)]
            public bool? ConfigSecretEnabled { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether the cluster supports configuration encryption. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: supported</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigSecretSupported")]
            [Validation(Required=false)]
            public bool? ConfigSecretSupported { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Nacos open source console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConsoleUIEnabled")]
            [Validation(Required=false)]
            public bool? ConsoleUIEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the four-letter words command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable4lw")]
            [Validation(Required=false)]
            public bool? Enable4lw { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable port 8761 for access to the Eureka protocol. If you disable this port, applications cannot use the Eureka protocol for service registration and discovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EurekaSupported")]
            [Validation(Required=false)]
            public bool? EurekaSupported { get; set; }

            /// <summary>
            /// <para>The ZooKeeper parameter that specifies whether to enable the TTL configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExtendedTypesEnable")]
            [Validation(Required=false)]
            public bool? ExtendedTypesEnable { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the maximum connection duration of an instance. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InitLimit")]
            [Validation(Required=false)]
            public string InitLimit { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the maximum data size of each node. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("JuteMaxbuffer")]
            [Validation(Required=false)]
            public string JuteMaxbuffer { get; set; }

            /// <summary>
            /// <para>A reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("JvmFlagsCustom")]
            [Validation(Required=false)]
            public string JvmFlagsCustom { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether Mesh Configuration Protocol (MCP) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MCPEnabled")]
            [Validation(Required=false)]
            public bool? MCPEnabled { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether MCP is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: supported</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MCPSupported")]
            [Validation(Required=false)]
            public bool? MCPSupported { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the number of connections between a client and a server.<br>
            /// If this parameter is set to 0, no limit is imposed.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxClientCnxns")]
            [Validation(Required=false)]
            public string MaxClientCnxns { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the maximum timeout duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MaxSessionTimeout")]
            [Validation(Required=false)]
            public string MaxSessionTimeout { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the minimum timeout duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinSessionTimeout")]
            [Validation(Required=false)]
            public string MinSessionTimeout { get; set; }

            /// <summary>
            /// <para>The runtime configuration of Nacos.</para>
            /// </summary>
            [NameInMap("NacosRunningEnv")]
            [Validation(Required=false)]
            public QueryConfigResponseBodyDataNacosRunningEnv NacosRunningEnv { get; set; }
            public class QueryConfigResponseBodyDataNacosRunningEnv : TeaModel {
                /// <summary>
                /// <para>The switch for push-empty protection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("emptyProtect")]
                [Validation(Required=false)]
                public bool? EmptyProtect { get; set; }

                [NameInMap("fenceEnabled")]
                [Validation(Required=false)]
                public bool? FenceEnabled { get; set; }

                [NameInMap("fencePolicy")]
                [Validation(Required=false)]
                public QueryConfigResponseBodyDataNacosRunningEnvFencePolicy FencePolicy { get; set; }
                public class QueryConfigResponseBodyDataNacosRunningEnvFencePolicy : TeaModel {
                    [NameInMap("enabledModules")]
                    [Validation(Required=false)]
                    public List<string> EnabledModules { get; set; }

                    [NameInMap("interceptPolicy")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> InterceptPolicy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>query_security_check</para>
                    /// </summary>
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("grayAuth")]
                [Validation(Required=false)]
                public string GrayAuth { get; set; }

            }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether RAM authentication is enabled for the service registry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NamingAuthEnabled")]
            [Validation(Required=false)]
            public bool? NamingAuthEnabled { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether the cluster supports RAM authentication for services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: supported</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NamingAuthSupported")]
            [Validation(Required=false)]
            public bool? NamingAuthSupported { get; set; }

            /// <summary>
            /// <para>The Nacos configuration. This parameter indicates whether the cluster supports service creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: supported</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: not supported</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NamingCreateServiceSupported")]
            [Validation(Required=false)]
            public bool? NamingCreateServiceSupported { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates whether the super permission is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenSuperAcl")]
            [Validation(Required=false)]
            public bool? OpenSuperAcl { get; set; }

            /// <summary>
            /// <para>The password. This parameter is returned only when OpenSuperAcl is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("PassWord")]
            [Validation(Required=false)]
            public string PassWord { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PrometheusSdProtocolEnabled")]
            [Validation(Required=false)]
            public string PrometheusSdProtocolEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster is restarted and the new configuration is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The cluster is restarted.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The cluster fails to be restarted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RestartFlag")]
            [Validation(Required=false)]
            public bool? RestartFlag { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the frequency of generating snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public string SnapshotCount { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates the connection timeout duration of an instance. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SyncLimit")]
            [Validation(Required=false)]
            public string SyncLimit { get; set; }

            /// <summary>
            /// <para>MSE Nacos instances of version 2.1.2.1 or later support Transport Layer Security (TLS) encryption. The version of the Nacos client must be 2.2.1 or later. After you enable TLS, the performance may decrease by about 10%. You must evaluate the system capacity. For more information about the operations, see Nacos TLS transport encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TLSEnabled")]
            [Validation(Required=false)]
            public bool? TLSEnabled { get; set; }

            /// <summary>
            /// <para>The ZooKeeper configuration. This parameter indicates a unit of time in the engine. The default value is 2000. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TickTime")]
            [Validation(Required=false)]
            public string TickTime { get; set; }

            /// <summary>
            /// <para>The username. This parameter is returned only when OpenSuperAcl is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BD1E58D-0755-42AC-A599-E6B55112EC53</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
