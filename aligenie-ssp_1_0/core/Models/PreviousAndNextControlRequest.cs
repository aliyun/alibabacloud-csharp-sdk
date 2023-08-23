// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PreviousAndNextControlRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PreviousAndNextControlRequestDeviceInfo DeviceInfo { get; set; }
        public class PreviousAndNextControlRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenControlPlayingListRequest")]
        [Validation(Required=false)]
        public PreviousAndNextControlRequestOpenControlPlayingListRequest OpenControlPlayingListRequest { get; set; }
        public class PreviousAndNextControlRequestOpenControlPlayingListRequest : TeaModel {
            [NameInMap("Cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("IsFromDevice")]
            [Validation(Required=false)]
            public bool? IsFromDevice { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public PreviousAndNextControlRequestUserInfo UserInfo { get; set; }
        public class PreviousAndNextControlRequestUserInfo : TeaModel {
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
