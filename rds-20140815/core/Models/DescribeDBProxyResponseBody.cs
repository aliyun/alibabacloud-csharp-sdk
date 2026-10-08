// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyResponseBody : TeaModel {
        [NameInMap("DBProxyAVZones")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyAVZones DBProxyAVZones { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyAVZones : TeaModel {
            [NameInMap("DBProxyAVZones")]
            [Validation(Required=false)]
            public List<string> DBProxyAVZones { get; set; }

        }

        [NameInMap("DBProxyConnectStringItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyConnectStringItems DBProxyConnectStringItems { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyConnectStringItems : TeaModel {
            [NameInMap("DBProxyConnectStringItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems> DBProxyConnectStringItems { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems : TeaModel {
                [NameInMap("DBProxyConnectString")]
                [Validation(Required=false)]
                public string DBProxyConnectString { get; set; }

                [NameInMap("DBProxyConnectStringNetType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetType { get; set; }

                [NameInMap("DBProxyConnectStringNetWorkType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetWorkType { get; set; }

                [NameInMap("DBProxyConnectStringPort")]
                [Validation(Required=false)]
                public string DBProxyConnectStringPort { get; set; }

                [NameInMap("DBProxyEndpointId")]
                [Validation(Required=false)]
                public string DBProxyEndpointId { get; set; }

                [NameInMap("DBProxyEndpointName")]
                [Validation(Required=false)]
                public string DBProxyEndpointName { get; set; }

                [NameInMap("DBProxyVpcId")]
                [Validation(Required=false)]
                public string DBProxyVpcId { get; set; }

                [NameInMap("DBProxyVpcInstanceId")]
                [Validation(Required=false)]
                public string DBProxyVpcInstanceId { get; set; }

                [NameInMap("DBProxyVswitchId")]
                [Validation(Required=false)]
                public string DBProxyVswitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The current minor version of the proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.13.11</para>
        /// </summary>
        [NameInMap("DBProxyInstanceCurrentMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceCurrentMinorVersion { get; set; }

        /// <summary>
        /// <para>The latest minor version of the proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.13.12</para>
        /// </summary>
        [NameInMap("DBProxyInstanceLatestMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceLatestMinorVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.25.9</para>
        /// </summary>
        [NameInMap("DBProxyInstanceMinorVersions")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyInstanceMinorVersions DBProxyInstanceMinorVersions { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyInstanceMinorVersions : TeaModel {
            [NameInMap("DBProxyInstanceMinorVersions")]
            [Validation(Required=false)]
            public List<string> DBProxyInstanceMinorVersions { get; set; }

        }

        /// <summary>
        /// <para>The name of the proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gos787jog2wk0ye1****</para>
        /// </summary>
        [NameInMap("DBProxyInstanceName")]
        [Validation(Required=false)]
        public string DBProxyInstanceName { get; set; }

        /// <summary>
        /// <para>The number of enabled proxy instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public int? DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for ApsaraDB RDS for PostgreSQL. The actual specification size of the proxy instance.</para>
        /// <para>Format: <c>CPU/Memory</c>.</para>
        /// <para>Example: 4/8 indicates 4 CPU cores and 8 GB of memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4/8</para>
        /// </summary>
        [NameInMap("DBProxyInstanceSize")]
        [Validation(Required=false)]
        public string DBProxyInstanceSize { get; set; }

        /// <summary>
        /// <para>The running status of the proxy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DBInstanceClassChanging: The specification is being changed.</description></item>
        /// <item><description>Creating: The instance is being created.</description></item>
        /// <item><description>Running: The instance is running.</description></item>
        /// <item><description>Deleting: The instance is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBProxyInstanceStatus")]
        [Validation(Required=false)]
        public string DBProxyInstanceStatus { get; set; }

        /// <summary>
        /// <para>The type of the proxy service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: shared database proxy</description></item>
        /// <item><description>2: dedicated database proxy</description></item>
        /// <item><description>3: general-purpose database proxy</description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for PostgreSQL does not support shared database proxies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("DBProxyKindCode")]
        [Validation(Required=false)]
        public string DBProxyKindCode { get; set; }

        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyNodes DBProxyNodes { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyNodes : TeaModel {
            [NameInMap("DBProxyNodes")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyNodesDBProxyNodes> DBProxyNodes { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyNodesDBProxyNodes : TeaModel {
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pn-xxxxxxx01</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The persistent connection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Persistent connections are enabled.</description></item>
        /// <item><description><b>Disabled</b>: Persistent connections are disabled.</description></item>
        /// <item><description><b>Unsupported</b>: The instance does not support persistent connections.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("DBProxyPersistentConnectionStatus")]
        [Validation(Required=false)]
        public string DBProxyPersistentConnectionStatus { get; set; }

        /// <summary>
        /// <para>The status of the database proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Shutdown: disabled</description></item>
        /// <item><description>Startup: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Startup</para>
        /// </summary>
        [NameInMap("DBProxyServiceStatus")]
        [Validation(Required=false)]
        public string DBProxyServiceStatus { get; set; }

        [NameInMap("DbProxyEndpointItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDbProxyEndpointItems DbProxyEndpointItems { get; set; }
        public class DescribeDBProxyResponseBodyDbProxyEndpointItems : TeaModel {
            [NameInMap("DbProxyEndpointItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems> DbProxyEndpointItems { get; set; }
            public class DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems : TeaModel {
                [NameInMap("DbProxyEndpointAliases")]
                [Validation(Required=false)]
                public string DbProxyEndpointAliases { get; set; }

                [NameInMap("DbProxyEndpointName")]
                [Validation(Required=false)]
                public string DbProxyEndpointName { get; set; }

                [NameInMap("DbProxyEndpointType")]
                [Validation(Required=false)]
                public string DbProxyEndpointType { get; set; }

                [NameInMap("DbProxyReadWriteMode")]
                [Validation(Required=false)]
                public string DbProxyReadWriteMode { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>909A69EE-71C8-4417-A0B9-FF085407E1E3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
