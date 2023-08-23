// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ReadMessageShrinkRequest : TeaModel {
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public long? MessageId { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
