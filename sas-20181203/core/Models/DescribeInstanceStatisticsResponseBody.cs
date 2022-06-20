// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyData> Data { get; set; }
        public class DescribeInstanceStatisticsResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public int? Account { get; set; }

            [NameInMap("AppNum")]
            [Validation(Required=false)]
            public int? AppNum { get; set; }

            [NameInMap("CmsNum")]
            [Validation(Required=false)]
            public int? CmsNum { get; set; }

            [NameInMap("CveNum")]
            [Validation(Required=false)]
            public int? CveNum { get; set; }

            [NameInMap("EmgNum")]
            [Validation(Required=false)]
            public int? EmgNum { get; set; }

            [NameInMap("Health")]
            [Validation(Required=false)]
            public int? Health { get; set; }

            [NameInMap("ScaNum")]
            [Validation(Required=false)]
            public int? ScaNum { get; set; }

            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

            [NameInMap("SysNum")]
            [Validation(Required=false)]
            public int? SysNum { get; set; }

            [NameInMap("Trojan")]
            [Validation(Required=false)]
            public int? Trojan { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            [NameInMap("WeakPWNum")]
            [Validation(Required=false)]
            public int? WeakPWNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
