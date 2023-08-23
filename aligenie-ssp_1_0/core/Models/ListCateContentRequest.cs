// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListCateContentRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public ListCateContentRequestDeviceInfo DeviceInfo { get; set; }
        public class ListCateContentRequestDeviceInfo : TeaModel {
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

        [NameInMap("Request")]
        [Validation(Required=false)]
        public ListCateContentRequestRequest Request { get; set; }
        public class ListCateContentRequestRequest : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("IsAlbum")]
            [Validation(Required=false)]
            public bool? IsAlbum { get; set; }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("SortBy")]
            [Validation(Required=false)]
            public string SortBy { get; set; }

            [NameInMap("SortOrder")]
            [Validation(Required=false)]
            public string SortOrder { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListCateContentRequestUserInfo UserInfo { get; set; }
        public class ListCateContentRequestUserInfo : TeaModel {
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
