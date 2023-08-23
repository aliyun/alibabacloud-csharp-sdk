// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetCodeEnhanceRequest : TeaModel {
        [NameInMap("ChannelInfo")]
        [Validation(Required=false)]
        public GetCodeEnhanceRequestChannelInfo ChannelInfo { get; set; }
        public class GetCodeEnhanceRequestChannelInfo : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetCodeEnhanceRequestUserInfo UserInfo { get; set; }
        public class GetCodeEnhanceRequestUserInfo : TeaModel {
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
