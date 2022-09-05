// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetUserFinishedAdRequest : TeaModel {
        [NameInMap("Adid")]
        [Validation(Required=false)]
        public long? Adid { get; set; }

        [NameInMap("Clicklink")]
        [Validation(Required=false)]
        public string Clicklink { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Mediaid")]
        [Validation(Required=false)]
        public string Mediaid { get; set; }

        [NameInMap("Tagid")]
        [Validation(Required=false)]
        public string Tagid { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
