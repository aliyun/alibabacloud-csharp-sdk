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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-09k1q11****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Resource Access Management (RAM) authentication for a configuration center. This parameter is valid for Nacos instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled.</description></item>
        /// <item><description><c>false</c>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you configure this parameter, you must call the QueryConfig operation to obtain the ConfigAuthSupported parameter value to check whether the instance supports the RAM authentication feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigAuthEnabled")]
        [Validation(Required=false)]
        public bool? ConfigAuthEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable configuration encryption for a configuration center. This parameter is valid for Nacos instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled.</description></item>
        /// <item><description><c>false</c>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you configure this parameter, you must call the QueryConfig operation to obtain the ConfigSecretSupported parameter value to check whether the instance supports configuration encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigSecretEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSecretEnabled { get; set; }

        /// <summary>
        /// <para>The format of the configuration. Supported formats include TEXT, JSON, XML, and HTML.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("ConsoleUIEnabled")]
        [Validation(Required=false)]
        public bool? ConsoleUIEnabled { get; set; }

        [NameInMap("Enable4lw")]
        [Validation(Required=false)]
        public bool? Enable4lw { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EurekaSupported")]
        [Validation(Required=false)]
        public bool? EurekaSupported { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the time to live (TTL) configuration. This parameter is valid for ZooKeeper instances.</para>
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
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-st2212****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum amount of data on each node. This parameter is valid for ZooKeeper instances. The default maximum data amount on each node is 1 megabyte. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048575</para>
        /// </summary>
        [NameInMap("JuteMaxbuffer")]
        [Validation(Required=false)]
        public string JuteMaxbuffer { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Mesh Configuration Protocol (MCP). This parameter is valid for Nacos instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled.</description></item>
        /// <item><description><c>false</c>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you configure this parameter, you must call the QueryConfig operation to obtain the MCPSupported parameter value to check whether the instance supports MCP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MCPEnabled")]
        [Validation(Required=false)]
        public bool? MCPEnabled { get; set; }

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
        /// <para>The maximum timeout period. This parameter is valid for ZooKeeper instances. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxSessionTimeout")]
        [Validation(Required=false)]
        public string MaxSessionTimeout { get; set; }

        /// <summary>
        /// <para>The minimum timeout period. This parameter is valid for ZooKeeper instances. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinSessionTimeout")]
        [Validation(Required=false)]
        public string MinSessionTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable RAM authentication for a registry. This parameter is valid for Nacos instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled.</description></item>
        /// <item><description><c>false</c>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you configure this parameter, you must call the QueryConfig operation to obtain the NamingAuthSupporte parameter value to check whether the instance supports the RAM authentication feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NamingAuthEnabled")]
        [Validation(Required=false)]
        public bool? NamingAuthEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable super permissions. This parameter is valid for ZooKeeper instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled</description></item>
        /// <item><description><c>false</c>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OpenSuperAcl")]
        [Validation(Required=false)]
        public string OpenSuperAcl { get; set; }

        /// <summary>
        /// <para>The password that corresponds to the username.</para>
        /// <remarks>
        /// <para>You must specify this parameter if OpenSuperAcl is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

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
        /// <para>The name of the user.</para>
        /// <remarks>
        /// <para>You must specify this parameter if OpenSuperAcl is set to true.</para>
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
