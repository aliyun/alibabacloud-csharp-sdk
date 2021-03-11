// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceResponseBody : TeaModel {
        [NameInMap("AlarmMethod")]
        [Validation(Required=false)]
        public string AlarmMethod { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("ChannelSyncTime")]
        [Validation(Required=false)]
        public string ChannelSyncTime { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Directory")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyDirectory Directory { get; set; }
        public class DescribeDeviceResponseBodyDirectory : TeaModel {
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

        [NameInMap("RegisteredTime")]
        [Validation(Required=false)]
        public string RegisteredTime { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("PosInterval")]
        [Validation(Required=false)]
        public long? PosInterval { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeDeviceResponseBodyStats Stats { get; set; }
        public class DescribeDeviceResponseBodyStats : TeaModel {
            [NameInMap("FailedNum")]
            [Validation(Required=false)]
            public long? FailedNum { get; set; }
            [NameInMap("StreamNum")]
            [Validation(Required=false)]
            public long? StreamNum { get; set; }
            [NameInMap("OnlineNum")]
            [Validation(Required=false)]
            public long? OnlineNum { get; set; }
            [NameInMap("OfflineNum")]
            [Validation(Required=false)]
            public long? OfflineNum { get; set; }
            [NameInMap("ChannelNum")]
            [Validation(Required=false)]
            public long? ChannelNum { get; set; }
        };

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
