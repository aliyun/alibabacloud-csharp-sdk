// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetCurrentPlayingListRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public GetCurrentPlayingListRequestDeviceInfo DeviceInfo { get; set; }
        public class GetCurrentPlayingListRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenQueryPlayListRequest")]
        [Validation(Required=false)]
        public GetCurrentPlayingListRequestOpenQueryPlayListRequest OpenQueryPlayListRequest { get; set; }
        public class GetCurrentPlayingListRequestOpenQueryPlayListRequest : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetCurrentPlayingListRequestUserInfo UserInfo { get; set; }
        public class GetCurrentPlayingListRequestUserInfo : TeaModel {
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
