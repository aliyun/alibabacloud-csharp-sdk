// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNShrinkRequest : TeaModel {
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        [NameInMap("BandwithPackageId")]
        [Validation(Required=false)]
        public string BandwithPackageId { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        [NameInMap("OtherRegion")]
        [Validation(Required=false)]
        public string OtherRegion { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("ThisIp")]
        [Validation(Required=false)]
        public string ThisIp { get; set; }

        [NameInMap("ThisPort")]
        [Validation(Required=false)]
        public string ThisPort { get; set; }

        [NameInMap("ThisRegion")]
        [Validation(Required=false)]
        public string ThisRegion { get; set; }

        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

    }

}
