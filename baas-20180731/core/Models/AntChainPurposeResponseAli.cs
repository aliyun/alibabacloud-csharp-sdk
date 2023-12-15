// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AntChainPurposeResponseAli : TeaModel {
        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<ChainPurposeInfoAli> RecordList { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
