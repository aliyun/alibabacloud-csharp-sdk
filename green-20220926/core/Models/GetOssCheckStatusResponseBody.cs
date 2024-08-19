// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// Bid。
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Buy")]
        [Validation(Required=false)]
        public bool? Buy { get; set; }

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("Indebt")]
        [Validation(Required=false)]
        public bool? Indebt { get; set; }

        [NameInMap("RamStatus")]
        [Validation(Required=false)]
        public string RamStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsStatus")]
        [Validation(Required=false)]
        public string SlsStatus { get; set; }

    }

}
