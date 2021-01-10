// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectOneruleofdaydetailRequest : TeaModel {
        [NameInMap("UnixTime")]
        [Validation(Required=false)]
        public long? UnixTime { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RequestBodyJsonStr")]
        [Validation(Required=false)]
        public string RequestBodyJsonStr { get; set; }

    }

}
