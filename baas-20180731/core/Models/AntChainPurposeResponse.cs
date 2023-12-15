/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AntChainPurposeResponse : TeaModel {
        [NameInMap("ChainPurposeExtend")]
        [Validation(Required=false)]
        public string ChainPurposeExtend { get; set; }

        [NameInMap("ChainPurposeItem")]
        [Validation(Required=false)]
        public string ChainPurposeItem { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        [NameInMap("RecordList")]
        [Validation(Required=false)]
        public List<ChainPurpose> RecordList { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
