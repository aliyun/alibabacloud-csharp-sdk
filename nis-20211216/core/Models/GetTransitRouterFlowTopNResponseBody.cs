// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TransitRouterFlowTopN")]
        [Validation(Required=false)]
        public List<GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN> TransitRouterFlowTopN { get; set; }
        public class GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("BandwithPackageId")]
            [Validation(Required=false)]
            public string BandwithPackageId { get; set; }

            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            [NameInMap("OtherRegion")]
            [Validation(Required=false)]
            public string OtherRegion { get; set; }

            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("ThisIp")]
            [Validation(Required=false)]
            public string ThisIp { get; set; }

            [NameInMap("ThisPort")]
            [Validation(Required=false)]
            public string ThisPort { get; set; }

            [NameInMap("ThisRegion")]
            [Validation(Required=false)]
            public string ThisRegion { get; set; }

        }

    }

}
