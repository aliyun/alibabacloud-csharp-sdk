// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreatePlayingListRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreatePlayingListRequestDeviceInfo DeviceInfo { get; set; }
        public class CreatePlayingListRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenCreatePlayingListRequest")]
        [Validation(Required=false)]
        public CreatePlayingListRequestOpenCreatePlayingListRequest OpenCreatePlayingListRequest { get; set; }
        public class CreatePlayingListRequestOpenCreatePlayingListRequest : TeaModel {
            [NameInMap("ContentList")]
            [Validation(Required=false)]
            public List<CreatePlayingListRequestOpenCreatePlayingListRequestContentList> ContentList { get; set; }
            public class CreatePlayingListRequestOpenCreatePlayingListRequestContentList : TeaModel {
                [NameInMap("RawId")]
                [Validation(Required=false)]
                public string RawId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("NeedAlbumContinued")]
            [Validation(Required=false)]
            public bool? NeedAlbumContinued { get; set; }

            [NameInMap("PlayFrom")]
            [Validation(Required=false)]
            public string PlayFrom { get; set; }

            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreatePlayingListRequestUserInfo UserInfo { get; set; }
        public class CreatePlayingListRequestUserInfo : TeaModel {
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
