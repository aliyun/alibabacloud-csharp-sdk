// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsResourceidMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsResourceidMetricsResponseBodyResponse Response { get; set; }
        public class QueryRmsResourceidMetricsResponseBodyResponse : TeaModel {
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsResourceidMetricsResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsResourceidMetricsResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsResourceidMetricsResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsResourceidMetricsResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Cursor")]
                    [Validation(Required=false)]
                    public string Cursor { get; set; }

                    [NameInMap("IaasId")]
                    [Validation(Required=false)]
                    public string IaasId { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("OptionKey")]
                    [Validation(Required=false)]
                    public string OptionKey { get; set; }

                    [NameInMap("PaasId")]
                    [Validation(Required=false)]
                    public string PaasId { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public string Period { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<QueryRmsResourceidMetricsResponseBodyResponseEntityDataMetrics> Metrics { get; set; }
                    public class QueryRmsResourceidMetricsResponseBodyResponseEntityDataMetrics : TeaModel {
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        [NameInMap("Datas")]
                        [Validation(Required=false)]
                        public List<QueryRmsResourceidMetricsResponseBodyResponseEntityDataMetricsDatas> Datas { get; set; }
                        public class QueryRmsResourceidMetricsResponseBodyResponseEntityDataMetricsDatas : TeaModel {
                            [NameInMap("Average")]
                            [Validation(Required=false)]
                            public long? Average { get; set; }

                            [NameInMap("Maximum")]
                            [Validation(Required=false)]
                            public long? Maximum { get; set; }

                            [NameInMap("Minimum")]
                            [Validation(Required=false)]
                            public long? Minimum { get; set; }

                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public long? Timestamp { get; set; }

                        }

                    }

                }

            }
        };

    }

}
