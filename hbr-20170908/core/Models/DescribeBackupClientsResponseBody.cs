// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            [NameInMap("Appliance")]
            [Validation(Required=false)]
            public bool? Appliance { get; set; }

            [NameInMap("ArchType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            [NameInMap("MaxClientVersion")]
            [Validation(Required=false)]
            public string MaxClientVersion { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("PrivateIpV4")]
            [Validation(Required=false)]
            public string PrivateIpV4 { get; set; }

            [NameInMap("Settings")]
            [Validation(Required=false)]
            public DescribeBackupClientsResponseBodyClientsSettings Settings { get; set; }
            public class DescribeBackupClientsResponseBodyClientsSettings : TeaModel {
                [NameInMap("DataNetworkType")]
                [Validation(Required=false)]
                public string DataNetworkType { get; set; }
                [NameInMap("DataProxySetting")]
                [Validation(Required=false)]
                public string DataProxySetting { get; set; }
                [NameInMap("MaxCpuCore")]
                [Validation(Required=false)]
                public string MaxCpuCore { get; set; }
                [NameInMap("MaxWorker")]
                [Validation(Required=false)]
                public string MaxWorker { get; set; }
                [NameInMap("ProxyHost")]
                [Validation(Required=false)]
                public string ProxyHost { get; set; }
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }
                [NameInMap("ProxyUser")]
                [Validation(Required=false)]
                public string ProxyUser { get; set; }
                [NameInMap("UseHttps")]
                [Validation(Required=false)]
                public string UseHttps { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeBackupClientsResponseBodyClientsTags> Tags { get; set; }
            public class DescribeBackupClientsResponseBodyClientsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
