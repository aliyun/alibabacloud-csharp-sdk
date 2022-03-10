// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddShareReportRequest : TeaModel {
        [NameInMap("AuthPoint")]
        [Validation(Required=false)]
        public int? AuthPoint { get; set; }

        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        [NameInMap("ShareToId")]
        [Validation(Required=false)]
        public string ShareToId { get; set; }

        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
