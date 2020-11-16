// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CompleteBoardRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("BoardId")]
        [Validation(Required=true)]
        public string BoardId { get; set; }

    }

}
