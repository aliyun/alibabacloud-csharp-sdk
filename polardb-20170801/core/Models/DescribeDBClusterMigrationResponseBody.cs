// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterMigrationResponseBody : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("DBClusterEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointList> DBClusterEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointList : TeaModel {
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyDBClusterEndpointListAddressItems : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DBClusterReadWriteMode")]
        [Validation(Required=false)]
        public string DBClusterReadWriteMode { get; set; }

        [NameInMap("DelayedSeconds")]
        [Validation(Required=false)]
        public int? DelayedSeconds { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("MigrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        [NameInMap("RdsEndpointList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterMigrationResponseBodyRdsEndpointList> RdsEndpointList { get; set; }
        public class DescribeDBClusterMigrationResponseBodyRdsEndpointList : TeaModel {
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterMigrationResponseBodyRdsEndpointListAddressItems : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("SSLEnabled")]
                [Validation(Required=false)]
                public string SSLEnabled { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        [NameInMap("RdsReadWriteMode")]
        [Validation(Required=false)]
        public string RdsReadWriteMode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceRDSDBInstanceId")]
        [Validation(Required=false)]
        public string SourceRDSDBInstanceId { get; set; }

        [NameInMap("Topologies")]
        [Validation(Required=false)]
        public string Topologies { get; set; }

    }

}
