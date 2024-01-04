// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class ListMotionShopTasksRequest : TeaModel {
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
