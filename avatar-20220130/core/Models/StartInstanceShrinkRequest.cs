// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class StartInstanceShrinkRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string AppShrink { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string ChannelShrink { get; set; }

        [NameInMap("CommandRequest")]
        [Validation(Required=false)]
        public string CommandRequestShrink { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TextRequest")]
        [Validation(Required=false)]
        public string TextRequestShrink { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string UserShrink { get; set; }

    }

}
