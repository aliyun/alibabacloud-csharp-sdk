// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnFullDomainsBlockIPHistoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IPBlockInfo")]
        [Validation(Required=false)]
        public List<DescribeCdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo> IPBlockInfo { get; set; }
        public class DescribeCdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo : TeaModel {
            [NameInMap("BlockIP")]
            [Validation(Required=false)]
            public string BlockIP { get; set; }

            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
