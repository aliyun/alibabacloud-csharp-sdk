// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceRequest : TeaModel {
        [NameInMap("AlarmMethod")]
        [Validation(Required=false)]
        public string AlarmMethod { get; set; }

        [NameInMap("AutoPos")]
        [Validation(Required=false)]
        public bool? AutoPos { get; set; }

        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("Dsn")]
        [Validation(Required=false)]
        public string Dsn { get; set; }

        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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

}
