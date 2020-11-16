// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ApplyBoardTokenRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("AppUid")]
        [Validation(Required=true)]
        public string AppUid { get; set; }

        [NameInMap("BoardId")]
        [Validation(Required=true)]
        public string BoardId { get; set; }

    }

}
