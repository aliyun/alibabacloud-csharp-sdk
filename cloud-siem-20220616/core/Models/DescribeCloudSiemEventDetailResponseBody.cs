// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemEventDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudSiemEventDetailResponseBodyData Data { get; set; }
        public class DescribeCloudSiemEventDetailResponseBodyData : TeaModel {
            [NameInMap("AlertNum")]
            [Validation(Required=false)]
            public int? AlertNum { get; set; }

            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public long? Aliuid { get; set; }

            [NameInMap("AssetNum")]
            [Validation(Required=false)]
            public int? AssetNum { get; set; }

            [NameInMap("AttCkLabels")]
            [Validation(Required=false)]
            public List<string> AttCkLabels { get; set; }

            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DescriptionEn")]
            [Validation(Required=false)]
            public string DescriptionEn { get; set; }

            [NameInMap("ExtContent")]
            [Validation(Required=false)]
            public string ExtContent { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("IncidentName")]
            [Validation(Required=false)]
            public string IncidentName { get; set; }

            [NameInMap("IncidentNameEn")]
            [Validation(Required=false)]
            public string IncidentNameEn { get; set; }

            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            [NameInMap("ThreatScore")]
            [Validation(Required=false)]
            public float? ThreatScore { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
