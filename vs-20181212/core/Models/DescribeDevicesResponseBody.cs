// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribeDevicesResponseBodyDevices : TeaModel {
            [NameInMap("AlarmMethod")]
            [Validation(Required=false)]
            public string AlarmMethod { get; set; }

            [NameInMap("AutoDirectory")]
            [Validation(Required=false)]
            public bool? AutoDirectory { get; set; }

            [NameInMap("AutoPos")]
            [Validation(Required=false)]
            public bool? AutoPos { get; set; }

            [NameInMap("AutoStart")]
            [Validation(Required=false)]
            public bool? AutoStart { get; set; }

            [NameInMap("ChannelSyncTime")]
            [Validation(Required=false)]
            public string ChannelSyncTime { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Directory")]
            [Validation(Required=false)]
            public DescribeDevicesResponseBodyDevicesDirectory Directory { get; set; }
            public class DescribeDevicesResponseBodyDevicesDirectory : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }
            };

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("Dsn")]
            [Validation(Required=false)]
            public string Dsn { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("GbId")]
            [Validation(Required=false)]
            public string GbId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("PosInterval")]
            [Validation(Required=false)]
            public long? PosInterval { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RegisteredTime")]
            [Validation(Required=false)]
            public string RegisteredTime { get; set; }

            [NameInMap("Stats")]
            [Validation(Required=false)]
            public DescribeDevicesResponseBodyDevicesStats Stats { get; set; }
            public class DescribeDevicesResponseBodyDevicesStats : TeaModel {
                [NameInMap("ChannelNum")]
                [Validation(Required=false)]
                public long? ChannelNum { get; set; }
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public long? FailedNum { get; set; }
                [NameInMap("OfflineNum")]
                [Validation(Required=false)]
                public long? OfflineNum { get; set; }
                [NameInMap("OnlineNum")]
                [Validation(Required=false)]
                public long? OnlineNum { get; set; }
                [NameInMap("StreamNum")]
                [Validation(Required=false)]
                public long? StreamNum { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
