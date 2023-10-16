// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class UpdateTrademarkNameRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("TmComment")]
        [Validation(Required=false)]
        public string TmComment { get; set; }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
