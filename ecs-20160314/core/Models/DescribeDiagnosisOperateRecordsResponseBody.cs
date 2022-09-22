// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDiagnosisOperateRecordsResponseBody : TeaModel {
        [NameInMap("DiagnosisOperateRecordModels")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisOperateRecordsResponseBodyDiagnosisOperateRecordModels> DiagnosisOperateRecordModels { get; set; }
        public class DescribeDiagnosisOperateRecordsResponseBodyDiagnosisOperateRecordModels : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("NewInstanceType")]
            [Validation(Required=false)]
            public string NewInstanceType { get; set; }

            [NameInMap("NewZoneId")]
            [Validation(Required=false)]
            public string NewZoneId { get; set; }

            [NameInMap("OperateDate")]
            [Validation(Required=false)]
            public string OperateDate { get; set; }

            [NameInMap("OperateRecordType")]
            [Validation(Required=false)]
            public string OperateRecordType { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
