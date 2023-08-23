// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class IndexControlPlayingListRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public IndexControlPlayingListRequestDeviceInfo DeviceInfo { get; set; }
        public class IndexControlPlayingListRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenIndexControlRequest")]
        [Validation(Required=false)]
        public IndexControlPlayingListRequestOpenIndexControlRequest OpenIndexControlRequest { get; set; }
        public class IndexControlPlayingListRequestOpenIndexControlRequest : TeaModel {
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("NeedContentContinued")]
            [Validation(Required=false)]
            public bool? NeedContentContinued { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public IndexControlPlayingListRequestUserInfo UserInfo { get; set; }
        public class IndexControlPlayingListRequestUserInfo : TeaModel {
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
