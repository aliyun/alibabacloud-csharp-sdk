// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeClusterAttributeResponseBody : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("ColdStorageStatus")]
        [Validation(Required=false)]
        public string ColdStorageStatus { get; set; }

        [NameInMap("ConnectionInfo")]
        [Validation(Required=false)]
        public DescribeClusterAttributeResponseBodyConnectionInfo ConnectionInfo { get; set; }
        public class DescribeClusterAttributeResponseBodyConnectionInfo : TeaModel {
            [NameInMap("HaRestConnectionString")]
            [Validation(Required=false)]
            public string HaRestConnectionString { get; set; }

            [NameInMap("HaRestPort")]
            [Validation(Required=false)]
            public string HaRestPort { get; set; }

            [NameInMap("HaThriftConnectionString")]
            [Validation(Required=false)]
            public string HaThriftConnectionString { get; set; }

            [NameInMap("HaThriftPort")]
            [Validation(Required=false)]
            public string HaThriftPort { get; set; }

            [NameInMap("ThriftConnectionString")]
            [Validation(Required=false)]
            public string ThriftConnectionString { get; set; }

            [NameInMap("ThriftPort")]
            [Validation(Required=false)]
            public string ThriftPort { get; set; }

            [NameInMap("UIProxyConnectionString")]
            [Validation(Required=false)]
            public string UIProxyConnectionString { get; set; }

            [NameInMap("ZKClassicConnectionStringList")]
            [Validation(Required=false)]
            public DescribeClusterAttributeResponseBodyConnectionInfoZKClassicConnectionStringList ZKClassicConnectionStringList { get; set; }
            public class DescribeClusterAttributeResponseBodyConnectionInfoZKClassicConnectionStringList : TeaModel {
                [NameInMap("String")]
                [Validation(Required=false)]
                public List<string> String { get; set; }

            }

            [NameInMap("ZKConnectionStringList")]
            [Validation(Required=false)]
            public DescribeClusterAttributeResponseBodyConnectionInfoZKConnectionStringList ZKConnectionStringList { get; set; }
            public class DescribeClusterAttributeResponseBodyConnectionInfoZKConnectionStringList : TeaModel {
                [NameInMap("String")]
                [Validation(Required=false)]
                public List<string> String { get; set; }

            }

            [NameInMap("ZKInnerConnectionStringList")]
            [Validation(Required=false)]
            public DescribeClusterAttributeResponseBodyConnectionInfoZKInnerConnectionStringList ZKInnerConnectionStringList { get; set; }
            public class DescribeClusterAttributeResponseBodyConnectionInfoZKInnerConnectionStringList : TeaModel {
                [NameInMap("String")]
                [Validation(Required=false)]
                public List<string> String { get; set; }

            }

            [NameInMap("ZKPort")]
            [Validation(Required=false)]
            public int? ZKPort { get; set; }

            [NameInMap("ZKPublicConnectionStringList")]
            [Validation(Required=false)]
            public DescribeClusterAttributeResponseBodyConnectionInfoZKPublicConnectionStringList ZKPublicConnectionStringList { get; set; }
            public class DescribeClusterAttributeResponseBodyConnectionInfoZKPublicConnectionStringList : TeaModel {
                [NameInMap("String")]
                [Validation(Required=false)]
                public List<string> String { get; set; }

            }

        }

        [NameInMap("CoreDiskQuantity")]
        [Validation(Required=false)]
        public int? CoreDiskQuantity { get; set; }

        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public string CoreDiskSize { get; set; }

        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        [NameInMap("CoreInstanceQuantity")]
        [Validation(Required=false)]
        public int? CoreInstanceQuantity { get; set; }

        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        [NameInMap("HasUser")]
        [Validation(Required=false)]
        public string HasUser { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        [NameInMap("MainVersion")]
        [Validation(Required=false)]
        public string MainVersion { get; set; }

        [NameInMap("MasterDiskSize")]
        [Validation(Required=false)]
        public int? MasterDiskSize { get; set; }

        [NameInMap("MasterDiskType")]
        [Validation(Required=false)]
        public string MasterDiskType { get; set; }

        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        [NameInMap("NetInfo")]
        [Validation(Required=false)]
        public DescribeClusterAttributeResponseBodyNetInfo NetInfo { get; set; }
        public class DescribeClusterAttributeResponseBodyNetInfo : TeaModel {
            [NameInMap("InnerIpAddress")]
            [Validation(Required=false)]
            public string InnerIpAddress { get; set; }

            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            [NameInMap("SecurityIpList")]
            [Validation(Required=false)]
            public string SecurityIpList { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public DescribeClusterAttributeResponseBodyNodeList NodeList { get; set; }
        public class DescribeClusterAttributeResponseBodyNodeList : TeaModel {
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<DescribeClusterAttributeResponseBodyNodeListNode> Node { get; set; }
            public class DescribeClusterAttributeResponseBodyNodeListNode : TeaModel {
                [NameInMap("DaemonList")]
                [Validation(Required=false)]
                public DescribeClusterAttributeResponseBodyNodeListNodeDaemonList DaemonList { get; set; }
                public class DescribeClusterAttributeResponseBodyNodeListNodeDaemonList : TeaModel {
                    [NameInMap("Daemon")]
                    [Validation(Required=false)]
                    public List<DescribeClusterAttributeResponseBodyNodeListNodeDaemonListDaemon> Daemon { get; set; }
                    public class DescribeClusterAttributeResponseBodyNodeListNodeDaemonListDaemon : TeaModel {
                        [NameInMap("DaemonName")]
                        [Validation(Required=false)]
                        public string DaemonName { get; set; }

                        [NameInMap("DaemonStatus")]
                        [Validation(Required=false)]
                        public string DaemonStatus { get; set; }

                    }

                }

                [NameInMap("MemStore")]
                [Validation(Required=false)]
                public string MemStore { get; set; }

                [NameInMap("NodeDiskQuantity")]
                [Validation(Required=false)]
                public string NodeDiskQuantity { get; set; }

                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public string NodeDiskSize { get; set; }

                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeInstanceType")]
                [Validation(Required=false)]
                public string NodeInstanceType { get; set; }

                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public string NodeStatus { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("RegionQuantity")]
                [Validation(Required=false)]
                public string RegionQuantity { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("StoreFile")]
                [Validation(Required=false)]
                public string StoreFile { get; set; }

            }

        }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UpdateStatus")]
        [Validation(Required=false)]
        public string UpdateStatus { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
