// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyResponseBody : TeaModel {
        /// <summary>
        /// The list of zones that are available for the database proxy.
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
        /// An array consisting of the information about the proxy endpoint that is created for the instance.
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
                /// The endpoint of the proxy terminal.
                /// </summary>
                [NameInMap("DBProxyConnectString")]
                [Validation(Required=false)]
                public string DBProxyConnectString { get; set; }

                /// <summary>
                /// The network type of the proxy endpoint.
                /// 
                /// Valid values:
                /// 
                /// *   OuterString
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     Internet
                /// 
                ///     <!-- -->
                /// 
                /// *   InnerString
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     internal network
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DBProxyConnectStringNetType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetType { get; set; }

                /// <summary>
                /// The network type of the database proxy.
                /// 
                /// Valid values:
                /// 
                /// *   0
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     Internet
                /// 
                ///     <!-- -->
                /// 
                /// *   1
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     classic network
                /// 
                ///     <!-- -->
                /// 
                /// *   2
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     virtual private cloud (VPC)
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DBProxyConnectStringNetWorkType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetWorkType { get; set; }

                /// <summary>
                /// The port number that is associated with the proxy endpoint.
                /// </summary>
                [NameInMap("DBProxyConnectStringPort")]
                [Validation(Required=false)]
                public string DBProxyConnectStringPort { get; set; }

                /// <summary>
                /// The ID of the proxy terminal to which the proxy endpoint belongs.
                /// </summary>
                [NameInMap("DBProxyEndpointId")]
                [Validation(Required=false)]
                public string DBProxyEndpointId { get; set; }

                /// <summary>
                /// The name of the proxy terminal to which the proxy endpoint belongs.
                /// </summary>
                [NameInMap("DBProxyEndpointName")]
                [Validation(Required=false)]
                public string DBProxyEndpointName { get; set; }

                /// <summary>
                /// The VPC that is associated with the proxy endpoint.
                /// </summary>
                [NameInMap("DBProxyVpcId")]
                [Validation(Required=false)]
                public string DBProxyVpcId { get; set; }

                /// <summary>
                /// The ID of the proxy instance.
                /// </summary>
                [NameInMap("DBProxyVpcInstanceId")]
                [Validation(Required=false)]
                public string DBProxyVpcInstanceId { get; set; }

                /// <summary>
                /// The vSwitch that is associated with the proxy endpoint.
                /// </summary>
                [NameInMap("DBProxyVswitchId")]
                [Validation(Required=false)]
                public string DBProxyVswitchId { get; set; }

            }

        }

        /// <summary>
        /// An internal parameter. You can ignore this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The version of the proxy instance.
        /// </summary>
        [NameInMap("DBProxyInstanceCurrentMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceCurrentMinorVersion { get; set; }

        /// <summary>
        /// The latest version that is available for the proxy instance.
        /// </summary>
        [NameInMap("DBProxyInstanceLatestMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceLatestMinorVersion { get; set; }

        /// <summary>
        /// The name of the proxy instance.
        /// </summary>
        [NameInMap("DBProxyInstanceName")]
        [Validation(Required=false)]
        public string DBProxyInstanceName { get; set; }

        /// <summary>
        /// The number of proxies that are enabled on the instance.
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public int? DBProxyInstanceNum { get; set; }

        /// <summary>
        /// This parameter is available only for ApsaraDB RDS for PostgreSQL instances. The specifications of the proxy instance that is enabled.
        /// 
        /// Format: `Number of cores/Memory capacity`.
        /// 
        /// For example, a value of 4/8 indicates that the proxy instance has 4 cores and 8 GB of memory.
        /// </summary>
        [NameInMap("DBProxyInstanceSize")]
        [Validation(Required=false)]
        public string DBProxyInstanceSize { get; set; }

        /// <summary>
        /// The status of the proxy instance.
        /// 
        /// Valid values:
        /// 
        /// *   DBInstanceClassChanging
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Creating
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Running
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Deleting
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DBProxyInstanceStatus")]
        [Validation(Required=false)]
        public string DBProxyInstanceStatus { get; set; }

        /// <summary>
        /// The type of the database proxy that is enabled on the instance.
        /// 
        /// > ApsaraDB RDS for PostgreSQL instances support only dedicated proxies.
        /// 
        /// Valid values:
        /// 
        /// *   1
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     shared proxy
        /// 
        ///     <!-- -->
        /// 
        /// *   2
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     dedicated proxy
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// The status of the database proxy.
        /// 
        /// Valid values:
        /// 
        /// *   Shutdown
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Startup
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DBProxyServiceStatus")]
        [Validation(Required=false)]
        public string DBProxyServiceStatus { get; set; }

        /// <summary>
        /// The proxy terminals of the instance.
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
                /// The description of the proxy terminal.
                /// </summary>
                [NameInMap("DbProxyEndpointAliases")]
                [Validation(Required=false)]
                public string DbProxyEndpointAliases { get; set; }

                /// <summary>
                /// The ID of the proxy terminal.
                /// </summary>
                [NameInMap("DbProxyEndpointName")]
                [Validation(Required=false)]
                public string DbProxyEndpointName { get; set; }

                /// <summary>
                /// The type of the proxy terminal.
                /// 
                /// Valid values:
                /// 
                /// *   Custom
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     custom proxy terminal
                /// 
                ///     <!-- -->
                /// 
                /// *   RWSplit
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     default proxy terminal
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DbProxyEndpointType")]
                [Validation(Required=false)]
                public string DbProxyEndpointType { get; set; }

                /// <summary>
                /// The read and write attributes of the proxy terminal.
                /// 
                /// Valid values:
                /// 
                /// *   ReadOnly
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   ReadWrite
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DbProxyReadWriteMode")]
                [Validation(Required=false)]
                public string DbProxyReadWriteMode { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
