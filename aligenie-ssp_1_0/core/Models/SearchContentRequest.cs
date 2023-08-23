// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class SearchContentRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public SearchContentRequestDeviceInfo DeviceInfo { get; set; }
        public class SearchContentRequestDeviceInfo : TeaModel {
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
        public SearchContentRequestRequest Request { get; set; }
        public class SearchContentRequestRequest : TeaModel {
            [NameInMap("Cate")]
            [Validation(Required=false)]
            public string Cate { get; set; }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            [NameInMap("QueryAlbum")]
            [Validation(Required=false)]
            public bool? QueryAlbum { get; set; }

            [NameInMap("SubCate")]
            [Validation(Required=false)]
            public string SubCate { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SearchContentRequestUserInfo UserInfo { get; set; }
        public class SearchContentRequestUserInfo : TeaModel {
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
