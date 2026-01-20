// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConfigResponseBodyData Data { get; set; }
        public class QueryConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether Simple Authentication and Security Layer (SASL) forced identity authentication is enabled for the ZooKeeper instance.</para>
            /// </summary>
            [NameInMap("AuthEnabled")]
            [Validation(Required=false)]
            public bool? AuthEnabled { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AutopurgePurgeInterval")]
            [Validation(Required=false)]
            public string AutopurgePurgeInterval { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("AutopurgeSnapRetainCount")]
            [Validation(Required=false)]
            public string AutopurgeSnapRetainCount { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>Indicates whether RAM authentication of a configuration center is enabled. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled.</description></item>
            /// <item><description><c>false</c>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigAuthEnabled")]
            [Validation(Required=false)]
            public bool? ConfigAuthEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether RAM authentication is supported by a configuration center of the instance. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supported.</description></item>
            /// <item><description><c>false</c>: not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigAuthSupported")]
            [Validation(Required=false)]
            public bool? ConfigAuthSupported { get; set; }

            /// <summary>
            /// <para>The maximum size of contents in a configuration. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ConfigContentLimit")]
            [Validation(Required=false)]
            public long? ConfigContentLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether configuration encryption of a configuration center is enabled by the instance. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled.</description></item>
            /// <item><description><c>false</c>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigSecretEnabled")]
            [Validation(Required=false)]
            public bool? ConfigSecretEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether configuration encryption of a configuration center is supported by the instance. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supported.</description></item>
            /// <item><description><c>false</c>: not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConfigSecretSupported")]
            [Validation(Required=false)]
            public bool? ConfigSecretSupported { get; set; }

            /// <summary>
            /// <para>Indicates whether the Nacos open source console is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConsoleUIEnabled")]
            [Validation(Required=false)]
            public bool? ConsoleUIEnabled { get; set; }

            [NameInMap("Enable4lw")]
            [Validation(Required=false)]
            public bool? Enable4lw { get; set; }

            /// <summary>
            /// <para>Indicates whether access port 8761 was enabled for Eureka. If this port is disabled, applications cannot use the Eureka protocol for service registration and discovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EurekaSupported")]
            [Validation(Required=false)]
            public bool? EurekaSupported { get; set; }

            /// <summary>
            /// <para>Indicates whether the time to live (TTL) configuration is enabled. This parameter is valid for ZooKeeper instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExtendedTypesEnable")]
            [Validation(Required=false)]
            public bool? ExtendedTypesEnable { get; set; }

            /// <summary>
            /// <para>The maximum connection duration of the instance. Unit: seconds. This parameter is valid for ZooKeeper instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InitLimit")]
            [Validation(Required=false)]
            public string InitLimit { get; set; }

            /// <summary>
            /// <para>The maximum amount of data on each node. This parameter is valid for ZooKeeper instances. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("JuteMaxbuffer")]
            [Validation(Required=false)]
            public string JuteMaxbuffer { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("JvmFlagsCustom")]
            [Validation(Required=false)]
            public string JvmFlagsCustom { get; set; }

            /// <summary>
            /// <para>Indicates whether Mesh Configuration Protocol (MCP) is enabled. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled.</description></item>
            /// <item><description><c>false</c>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MCPEnabled")]
            [Validation(Required=false)]
            public bool? MCPEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether MCP is supported. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supported.</description></item>
            /// <item><description><c>false</c>: not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MCPSupported")]
            [Validation(Required=false)]
            public bool? MCPSupported { get; set; }

            /// <summary>
            /// <para>The number of connections between a client and a server. This parameter is valid for ZooKeeper instances.\
            /// If this parameter is set to 0, no limits are imposed on the number of connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxClientCnxns")]
            [Validation(Required=false)]
            public string MaxClientCnxns { get; set; }

            /// <summary>
            /// <para>The maximum timeout period. This parameter is valid for ZooKeeper instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MaxSessionTimeout")]
            [Validation(Required=false)]
            public string MaxSessionTimeout { get; set; }

            /// <summary>
            /// <para>The minimum timeout period. This parameter is valid for ZooKeeper instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinSessionTimeout")]
            [Validation(Required=false)]
            public string MinSessionTimeout { get; set; }

            /// <summary>
            /// <para>The runtime configuration of the Nacos instance.</para>
            /// </summary>
            [NameInMap("NacosRunningEnv")]
            [Validation(Required=false)]
            public QueryConfigResponseBodyDataNacosRunningEnv NacosRunningEnv { get; set; }
            public class QueryConfigResponseBodyDataNacosRunningEnv : TeaModel {
                /// <summary>
                /// <para>Indicates whether empty list protection is enabled.</para>
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

                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("grayAuth")]
                [Validation(Required=false)]
                public string GrayAuth { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether RAM authentication of a registry is enabled. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled.</description></item>
            /// <item><description><c>false</c>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NamingAuthEnabled")]
            [Validation(Required=false)]
            public bool? NamingAuthEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether RAM authentication of services is supported by the instance. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supported.</description></item>
            /// <item><description><c>false</c>: not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NamingAuthSupported")]
            [Validation(Required=false)]
            public bool? NamingAuthSupported { get; set; }

            /// <summary>
            /// <para>Indicates whether service creation is supported for the instance. This parameter is valid for Nacos instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: supported.</description></item>
            /// <item><description><c>false</c>: not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NamingCreateServiceSupported")]
            [Validation(Required=false)]
            public bool? NamingCreateServiceSupported { get; set; }

            /// <summary>
            /// <para>Indicates whether super permissions are enabled. This parameter is valid for ZooKeeper instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled.</description></item>
            /// <item><description><c>false</c>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenSuperAcl")]
            [Validation(Required=false)]
            public bool? OpenSuperAcl { get; set; }

            /// <summary>
            /// <para>The password that corresponds to the username. This parameter is valid only if OpenSuperAcl is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("PassWord")]
            [Validation(Required=false)]
            public string PassWord { get; set; }

            [NameInMap("PrometheusSdProtocolEnabled")]
            [Validation(Required=false)]
            public string PrometheusSdProtocolEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance was restarted and new configurations have taken effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The restart was successful.</description></item>
            /// <item><description><c>false</c>: The restart failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RestartFlag")]
            [Validation(Required=false)]
            public bool? RestartFlag { get; set; }

            /// <summary>
            /// <para>The frequency for generating snapshots. This parameter is valid for ZooKeeper instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public string SnapshotCount { get; set; }

            /// <summary>
            /// <para>The connection timeout period of the instance. This parameter is valid for ZooKeeper instances. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SyncLimit")]
            [Validation(Required=false)]
            public string SyncLimit { get; set; }

            /// <summary>
            /// <para>MSE Nacos supports TLS transmission link encryption since version 2.1.2.1. Nacos clients must be upgraded to version 2.2.1 or later. After TLS is enabled, the system performance will decrease by about 10%. You must evaluate the system capacity. For more information about the relevant operations, see Nacos TLS transmission encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TLSEnabled")]
            [Validation(Required=false)]
            public bool? TLSEnabled { get; set; }

            /// <summary>
            /// <para>The time unit of the engine. This parameter is valid for ZooKeeper instances. Default value: 2000. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TickTime")]
            [Validation(Required=false)]
            public string TickTime { get; set; }

            /// <summary>
            /// <para>The username of the user. This parameter is valid only if OpenSuperAcl is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
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
        /// <para>The request was successfully processed.</para>
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
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
