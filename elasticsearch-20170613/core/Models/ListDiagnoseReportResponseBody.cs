// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnoseReportResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDiagnoseReportResponseBodyHeaders Headers { get; set; }
        public class ListDiagnoseReportResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDiagnoseReportResponseBodyResult> Result { get; set; }
        public class ListDiagnoseReportResponseBodyResult : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("diagnoseItems")]
            [Validation(Required=false)]
            public List<ListDiagnoseReportResponseBodyResultDiagnoseItems> DiagnoseItems { get; set; }
            public class ListDiagnoseReportResponseBodyResultDiagnoseItems : TeaModel {
                [NameInMap("detail")]
                [Validation(Required=false)]
                public ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail Detail { get; set; }
                public class ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail : TeaModel {
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
                };

                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                [NameInMap("item")]
                [Validation(Required=false)]
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

        }

    }

}
