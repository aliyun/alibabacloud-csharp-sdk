// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced Simple Authentication and Security Layer (SASL) authentication. After this feature is enabled, clients that do not perform SASL authentication cannot access the cluster</para>
        /// </summary>
        [NameInMap("AuthEnabled")]
        [Validation(Required=false)]
        public bool? AuthEnabled { get; set; }

        /// <summary>
        /// <para>The reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("AutopurgePurgeInterval")]
        [Validation(Required=false)]
        public string AutopurgePurgeInterval { get; set; }

        /// <summary>
        /// <para>The reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("AutopurgeSnapRetainCount")]
        [Validation(Required=false)]
        public string AutopurgeSnapRetainCount { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-09k1q11****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable RAM authentication for the configuration center in Nacos:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you set this parameter, call the QueryConfig operation to obtain the ConfigAuthSupported parameter to check whether the current cluster supports this feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigAuthEnabled")]
        [Validation(Required=false)]
        public bool? ConfigAuthEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the configuration encryption feature for the configuration center in Nacos. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you set this parameter, call the QueryConfig operation to obtain the ConfigSecretSupported parameter to check whether the current cluster supports this feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigSecretEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSecretEnabled { get; set; }

        /// <summary>
        /// <para>The format of the configurations. Supported formats include TEXT, JSON, XML, and HTML.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Nacos open-source console</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConsoleUIEnabled")]
        [Validation(Required=false)]
        public bool? ConsoleUIEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the four-character command access feature</para>
        /// </summary>
        [NameInMap("Enable4lw")]
        [Validation(Required=false)]
        public bool? Enable4lw { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Eureka protocol support in Nacos</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EurekaSupported")]
        [Validation(Required=false)]
        public bool? EurekaSupported { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable TTL configuration in ZooKeeper parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExtendedTypesEnable")]
        [Validation(Required=false)]
        public string ExtendedTypesEnable { get; set; }

        /// <summary>
        /// <para>The maximum connection duration of the instance. This parameter is valid for ZooKeeper instances. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InitLimit")]
        [Validation(Required=false)]
        public string InitLimit { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-st2212****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum amount of data on each node. This parameter is valid for ZooKeeper instances. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048575</para>
        /// </summary>
        [NameInMap("JuteMaxbuffer")]
        [Validation(Required=false)]
        public string JuteMaxbuffer { get; set; }

        /// <summary>
        /// <para>Specifies whether MCP is enabled in Nacos configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you set this parameter, call the QueryConfig operation to obtain the MCPSupported parameter to check whether the current cluster supports this feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MCPEnabled")]
        [Validation(Required=false)]
        public bool? MCPEnabled { get; set; }

        /// <summary>
        /// <para>The number of connections between a single client and a single server in ZooKeeper configuration.<br>
        /// If this parameter is set to 0, no limits are imposed on the number of connections.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxClientCnxns")]
        [Validation(Required=false)]
        public string MaxClientCnxns { get; set; }

        /// <summary>
        /// <para>The maximum timeout period in ZooKeeper configuration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxSessionTimeout")]
        [Validation(Required=false)]
        public string MaxSessionTimeout { get; set; }

        /// <summary>
        /// <para>The minimum timeout period in ZooKeeper configuration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinSessionTimeout")]
        [Validation(Required=false)]
        public string MinSessionTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable RAM authentication for the Accreditation Centre in Nacos:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you set this parameter, call the QueryConfig operation to obtain the NamingAuthSupporte parameter to check whether the current cluster supports this feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NamingAuthEnabled")]
        [Validation(Required=false)]
        public bool? NamingAuthEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether super permissions are enabled. This parameter is valid for ZooKeeper instances. Valid values:</para>
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
        public string OpenSuperAcl { get; set; }

        /// <summary>
        /// <para>The password of the account.</para>
        /// <remarks>
        /// <para>This parameter is required when OpenSuperAcl is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// <para>The extended request parameter in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The frequency at which snapshots are generated in ZooKeeper configuration</para>
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
        /// <para>Specifies whether to enable TLS transmission link encryption in Nacos</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TLSEnabled")]
        [Validation(Required=false)]
        public bool? TLSEnabled { get; set; }

        /// <summary>
        /// <para>The time unit. This parameter is valid for ZooKeeper instances. Default value: 2000. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("TickTime")]
        [Validation(Required=false)]
        public string TickTime { get; set; }

        /// <summary>
        /// <para>The username of the account.</para>
        /// <remarks>
        /// <para>This parameter is required when OpenSuperAcl is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
