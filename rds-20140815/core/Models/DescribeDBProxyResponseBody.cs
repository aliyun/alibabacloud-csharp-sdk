// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of zones that are available for the database proxy.</para>
        /// </summary>
        [NameInMap("DBProxyAVZones")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyAVZones DBProxyAVZones { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyAVZones : TeaModel {
            [NameInMap("DBProxyAVZones")]
            [Validation(Required=false)]
            public List<string> DBProxyAVZones { get; set; }

        }

        /// <summary>
        /// <para>An array consisting of the information about the database proxy endpoint that is created for the instance.</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyConnectStringItems DBProxyConnectStringItems { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyConnectStringItems : TeaModel {
            [NameInMap("DBProxyConnectStringItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems> DBProxyConnectStringItems { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems : TeaModel {
                /// <summary>
                /// <para>The database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gos787jog2wk0ye1****-rw4rm.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DBProxyConnectString")]
                [Validation(Required=false)]
                public string DBProxyConnectString { get; set; }

                /// <summary>
                /// <para>The network type of the database proxy endpoint. A database proxy endpoint is formerly referred to as a proxy terminal. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OuterString: Internet</description></item>
                /// <item><description>InnerString: internal network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InnerString</para>
                /// </summary>
                [NameInMap("DBProxyConnectStringNetType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetType { get; set; }

                /// <summary>
                /// <para>The network type of the database proxy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Internet</description></item>
                /// <item><description>1: classic network</description></item>
                /// <item><description>2: virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBProxyConnectStringNetWorkType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetWorkType { get; set; }

                /// <summary>
                /// <para>The port that is associated with the database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("DBProxyConnectStringPort")]
                [Validation(Required=false)]
                public string DBProxyConnectStringPort { get; set; }

                /// <summary>
                /// <para>The ID of the backend database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20****</para>
                /// </summary>
                [NameInMap("DBProxyEndpointId")]
                [Validation(Required=false)]
                public string DBProxyEndpointId { get; set; }

                /// <summary>
                /// <para>The name of the database proxy endpoint. The name can be replaced by the ID of the database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gos787jog2wk0ye1****</para>
                /// </summary>
                [NameInMap("DBProxyEndpointName")]
                [Validation(Required=false)]
                public string DBProxyEndpointName { get; set; }

                /// <summary>
                /// <para>The VPC of the database proxy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6oobt****</para>
                /// </summary>
                [NameInMap("DBProxyVpcId")]
                [Validation(Required=false)]
                public string DBProxyVpcId { get; set; }

                /// <summary>
                /// <para>The ID of the database proxy instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp145737x5<b><b>131161274792</b></b></para>
                /// </summary>
                [NameInMap("DBProxyVpcInstanceId")]
                [Validation(Required=false)]
                public string DBProxyVpcInstanceId { get; set; }

                /// <summary>
                /// <para>The vSwitch of the database proxy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6l0pic17****</para>
                /// </summary>
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
        /// <para>The version of the proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.13.11</para>
        /// </summary>
        [NameInMap("DBProxyInstanceCurrentMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceCurrentMinorVersion { get; set; }

        /// <summary>
        /// <para>The latest version that is available for the proxy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.13.12</para>
        /// </summary>
        [NameInMap("DBProxyInstanceLatestMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceLatestMinorVersion { get; set; }

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
        /// <para>The number of proxies that are enabled on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public int? DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>This parameter is available only for ApsaraDB RDS for PostgreSQL instances. The specifications of the proxy instance that is enabled.</para>
        /// <para>Format: <c>Number of cores/Memory capacity</c>.</para>
        /// <para>For example, a value of 4/8 indicates that the proxy instance has 4 cores and 8 GB of memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4/8</para>
        /// </summary>
        [NameInMap("DBProxyInstanceSize")]
        [Validation(Required=false)]
        public string DBProxyInstanceSize { get; set; }

        /// <summary>
        /// <para>The status of the proxy instance.</para>
        /// <list type="bullet">
        /// <item><description>DBInstanceClassChanging: The specifications of the proxy instance are being changed.</description></item>
        /// <item><description>Creating: The proxy instance is being created.</description></item>
        /// <item><description>Running: The proxy instance is running.</description></item>
        /// <item><description>Deleting: The proxy instance is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBProxyInstanceStatus")]
        [Validation(Required=false)]
        public string DBProxyInstanceStatus { get; set; }

        /// <summary>
        /// <para>The type of the database proxy that is enabled on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: shared database proxy</description></item>
        /// <item><description>2: dedicated database proxy</description></item>
        /// <item><description>3: general-purpose database proxy</description></item>
        /// </list>
        /// <remarks>
        /// <para> ApsaraDB RDS for PostgreSQL does not support shared database proxies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>Internal parameters, no need to pay attention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("DBProxyKindCode")]
        [Validation(Required=false)]
        public string DBProxyKindCode { get; set; }

        /// <summary>
        /// <para>The proxy node list.</para>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyNodes DBProxyNodes { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyNodes : TeaModel {
            [NameInMap("DBProxyNodes")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyNodesDBProxyNodes> DBProxyNodes { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyNodesDBProxyNodes : TeaModel {
                /// <summary>
                /// <para>The number of cpu cores for the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                /// <summary>
                /// <para>The proxy node id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pn-xxxxxxx01</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The id of the availability zone where the node is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-c</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of persistence connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// <item><description><b>Unsupported</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("DBProxyPersistentConnectionStatus")]
        [Validation(Required=false)]
        public string DBProxyPersistentConnectionStatus { get; set; }

        /// <summary>
        /// <para>The status of the database proxy.</para>
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

        /// <summary>
        /// <para>The proxy terminals of the instance.</para>
        /// </summary>
        [NameInMap("DbProxyEndpointItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDbProxyEndpointItems DbProxyEndpointItems { get; set; }
        public class DescribeDBProxyResponseBodyDbProxyEndpointItems : TeaModel {
            [NameInMap("DbProxyEndpointItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems> DbProxyEndpointItems { get; set; }
            public class DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems : TeaModel {
                /// <summary>
                /// <para>The description of the database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>proxy-test</para>
                /// </summary>
                [NameInMap("DbProxyEndpointAliases")]
                [Validation(Required=false)]
                public string DbProxyEndpointAliases { get; set; }

                /// <summary>
                /// <para>The ID of the database proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gos787jog2wk0ye1****</para>
                /// </summary>
                [NameInMap("DbProxyEndpointName")]
                [Validation(Required=false)]
                public string DbProxyEndpointName { get; set; }

                /// <summary>
                /// <para>The type of the database proxy endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom: custom database proxy endpoint</description></item>
                /// <item><description>RWSplit: default database proxy endpoint</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RWSplit</para>
                /// </summary>
                [NameInMap("DbProxyEndpointType")]
                [Validation(Required=false)]
                public string DbProxyEndpointType { get; set; }

                /// <summary>
                /// <para>The read and write attributes of the database proxy endpoint.</para>
                /// <list type="bullet">
                /// <item><description>ReadOnly</description></item>
                /// <item><description>ReadWrite</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ReadWrite</para>
                /// </summary>
                [NameInMap("DbProxyReadWriteMode")]
                [Validation(Required=false)]
                public string DbProxyReadWriteMode { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>909A69EE-71C8-4417-A0B9-FF085407E1E3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
