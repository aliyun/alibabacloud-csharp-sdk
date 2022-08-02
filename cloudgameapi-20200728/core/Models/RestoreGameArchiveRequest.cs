// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class RestoreGameArchiveRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("ArchiveId")]
        [Validation(Required=false)]
        public string ArchiveId { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

    }

}
