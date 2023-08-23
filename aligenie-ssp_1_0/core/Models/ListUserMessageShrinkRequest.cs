// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListUserMessageShrinkRequest : TeaModel {
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public string BeforeTime { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
