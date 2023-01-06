// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUserBasicInfosResponseBody : TeaModel {
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserBasicInfos")]
        [Validation(Required=false)]
        public ListUserBasicInfosResponseBodyUserBasicInfos UserBasicInfos { get; set; }
        public class ListUserBasicInfosResponseBodyUserBasicInfos : TeaModel {
            [NameInMap("UserBasicInfo")]
            [Validation(Required=false)]
            public List<ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfo> UserBasicInfo { get; set; }
            public class ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfo : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfoTags Tags { get; set; }
                public class ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfoTagsTag> Tag { get; set; }
                    public class ListUserBasicInfosResponseBodyUserBasicInfosUserBasicInfoTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

        }

    }

}
