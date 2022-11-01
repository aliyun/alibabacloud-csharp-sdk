// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeInstanceGroupRequest : TeaModel {
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

    }

}
