// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAttackTimeLineResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAttackTimeLineResponseBodyData> Data { get; set; }
        public class DescribeAttackTimeLineResponseBodyData : TeaModel {
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("AlertNameCode")]
            [Validation(Required=false)]
            public string AlertNameCode { get; set; }

            [NameInMap("AlertNameEn")]
            [Validation(Required=false)]
            public string AlertNameEn { get; set; }

            [NameInMap("AlertSrcProd")]
            [Validation(Required=false)]
            public string AlertSrcProd { get; set; }

            [NameInMap("AlertSrcProdModule")]
            [Validation(Required=false)]
            public string AlertSrcProdModule { get; set; }

            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            [NameInMap("AlertTitle")]
            [Validation(Required=false)]
            public string AlertTitle { get; set; }

            [NameInMap("AlertTitleEn")]
            [Validation(Required=false)]
            public string AlertTitleEn { get; set; }

            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            [NameInMap("AlertTypeCode")]
            [Validation(Required=false)]
            public string AlertTypeCode { get; set; }

            [NameInMap("AlertTypeEn")]
            [Validation(Required=false)]
            public string AlertTypeEn { get; set; }

            [NameInMap("AlertUuid")]
            [Validation(Required=false)]
            public string AlertUuid { get; set; }

            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            [NameInMap("AssetList")]
            [Validation(Required=false)]
            public string AssetList { get; set; }

            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            [NameInMap("AttCk")]
            [Validation(Required=false)]
            public string AttCk { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

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
