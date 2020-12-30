// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcRouteRulesRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        [NameInMap("RouteComment")]
        [Validation(Required=false)]
        public string RouteComment { get; set; }

        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("RouteIp")]
        [Validation(Required=false)]
        public string RouteIp { get; set; }

    }

}
