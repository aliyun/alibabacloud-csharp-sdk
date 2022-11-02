// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowChartResponseBody : TeaModel {
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribeFlowChartResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribeFlowChartResponseBodyFlowChart : TeaModel {
            [NameInMap("AclCustomBlockSum")]
            [Validation(Required=false)]
            public long? AclCustomBlockSum { get; set; }

            [NameInMap("AclCustomReportsSum")]
            [Validation(Required=false)]
            public long? AclCustomReportsSum { get; set; }

            [NameInMap("AntiScanBlockSum")]
            [Validation(Required=false)]
            public long? AntiScanBlockSum { get; set; }

            [NameInMap("AntibotBlockSum")]
            [Validation(Required=false)]
            public long? AntibotBlockSum { get; set; }

            [NameInMap("AntibotReportSum")]
            [Validation(Required=false)]
            public string AntibotReportSum { get; set; }

            [NameInMap("AntiscanReportsSum")]
            [Validation(Required=false)]
            public long? AntiscanReportsSum { get; set; }

            [NameInMap("BlacklistBlockSum")]
            [Validation(Required=false)]
            public string BlacklistBlockSum { get; set; }

            [NameInMap("BlacklistReportsSum")]
            [Validation(Required=false)]
            public long? BlacklistReportsSum { get; set; }

            [NameInMap("CcCustomBlockSum")]
            [Validation(Required=false)]
            public long? CcCustomBlockSum { get; set; }

            [NameInMap("CcCustomReportsSum")]
            [Validation(Required=false)]
            public long? CcCustomReportsSum { get; set; }

            [NameInMap("CcSystemBlocksSum")]
            [Validation(Required=false)]
            public long? CcSystemBlocksSum { get; set; }

            [NameInMap("CcSystemReportsSum")]
            [Validation(Required=false)]
            public long? CcSystemReportsSum { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("MaxPv")]
            [Validation(Required=false)]
            public long? MaxPv { get; set; }

            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("RegionBlockBlocksSum")]
            [Validation(Required=false)]
            public long? RegionBlockBlocksSum { get; set; }

            [NameInMap("RegionBlockReportsSum")]
            [Validation(Required=false)]
            public long? RegionBlockReportsSum { get; set; }

            [NameInMap("WafBlockSum")]
            [Validation(Required=false)]
            public long? WafBlockSum { get; set; }

            [NameInMap("WafReportSum")]
            [Validation(Required=false)]
            public string WafReportSum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
