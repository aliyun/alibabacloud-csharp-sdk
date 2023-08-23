// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AddAndRemoveFavoriteContentRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestDeviceInfo DeviceInfo { get; set; }
        public class AddAndRemoveFavoriteContentRequestDeviceInfo : TeaModel {
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

        [NameInMap("OpenAddAndRemoveFavoriteContentRequest")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequest OpenAddAndRemoveFavoriteContentRequest { get; set; }
        public class AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequest : TeaModel {
            [NameInMap("FavoriteCmd")]
            [Validation(Required=false)]
            public string FavoriteCmd { get; set; }

            [NameInMap("OpenSourceRawIdPair")]
            [Validation(Required=false)]
            public AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequestOpenSourceRawIdPair OpenSourceRawIdPair { get; set; }
            public class AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequestOpenSourceRawIdPair : TeaModel {
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendInfo { get; set; }

                [NameInMap("RawId")]
                [Validation(Required=false)]
                public string RawId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestUserInfo UserInfo { get; set; }
        public class AddAndRemoveFavoriteContentRequestUserInfo : TeaModel {
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
