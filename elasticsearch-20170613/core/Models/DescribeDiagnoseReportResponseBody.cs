// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnoseReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiagnoseReportResponseBodyResult Result { get; set; }
        public class DescribeDiagnoseReportResponseBodyResult : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("diagnoseItems")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportResponseBodyResultDiagnoseItems> DiagnoseItems { get; set; }
            public class DescribeDiagnoseReportResponseBodyResultDiagnoseItems : TeaModel {
                public DescribeDiagnoseReportResponseBodyResultDiagnoseItemsDetail Detail { get; set; }
                public class DescribeDiagnoseReportResponseBodyResultDiagnoseItemsDetail : TeaModel {
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("suggest")]
                    [Validation(Required=false)]
                    public string Suggest { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                public string Health { get; set; }
                public string Item { get; set; }
            }
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }
        };

    }

}
