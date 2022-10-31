// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveShowFromShowListRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        [NameInMap("isBatchMode")]
        [Validation(Required=false)]
        public bool? IsBatchMode { get; set; }

        [NameInMap("showIdList")]
        [Validation(Required=false)]
        public List<string> ShowIdList { get; set; }

    }

}
