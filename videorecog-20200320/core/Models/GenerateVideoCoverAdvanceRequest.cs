// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class GenerateVideoCoverAdvanceRequest : TeaModel {
        [NameInMap("IsGif")]
        [Validation(Required=false)]
        public bool? IsGif { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
