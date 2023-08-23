// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubAlbumRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public ListSubAlbumRequestDeviceInfo DeviceInfo { get; set; }
        public class ListSubAlbumRequestDeviceInfo : TeaModel {
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

        /// <summary>
        /// request
        /// </summary>
        [NameInMap("QuerySubscriptionAlbumRequest")]
        [Validation(Required=false)]
        public ListSubAlbumRequestQuerySubscriptionAlbumRequest QuerySubscriptionAlbumRequest { get; set; }
        public class ListSubAlbumRequestQuerySubscriptionAlbumRequest : TeaModel {
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListSubAlbumRequestQuerySubscriptionAlbumRequestPage Page { get; set; }
            public class ListSubAlbumRequestQuerySubscriptionAlbumRequestPage : TeaModel {
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListSubAlbumRequestUserInfo UserInfo { get; set; }
        public class ListSubAlbumRequestUserInfo : TeaModel {
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
