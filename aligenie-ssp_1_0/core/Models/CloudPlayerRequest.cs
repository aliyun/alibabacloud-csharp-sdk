// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CloudPlayerRequest : TeaModel {
        [NameInMap("CurPlayIndex")]
        [Validation(Required=false)]
        public int? CurPlayIndex { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CloudPlayerRequestDeviceInfo DeviceInfo { get; set; }
        public class CloudPlayerRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("PlayMode")]
        [Validation(Required=false)]
        public string PlayMode { get; set; }

        [NameInMap("SongId")]
        [Validation(Required=false)]
        public string SongId { get; set; }

        [NameInMap("SongIdList")]
        [Validation(Required=false)]
        public List<string> SongIdList { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CloudPlayerRequestUserInfo UserInfo { get; set; }
        public class CloudPlayerRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
