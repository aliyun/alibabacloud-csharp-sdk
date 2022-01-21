// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterOutputListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterOutputListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterOutputListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterOutputListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterOutputListResponseBodyDatapointsDatapoint : TeaModel {
                public DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson ConfigJson { get; set; }
                public class DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson : TeaModel {
                    [NameInMap("ak")]
                    [Validation(Required=false)]
                    public string Ak { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }
                public long? CreateTime { get; set; }
                public string DestName { get; set; }
                public string DestType { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
