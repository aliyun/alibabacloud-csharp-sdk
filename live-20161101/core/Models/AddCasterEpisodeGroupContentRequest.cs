// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupContentRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

        [NameInMap("Content")]
        [Validation(Required=true)]
        public string Content { get; set; }

    }

}
