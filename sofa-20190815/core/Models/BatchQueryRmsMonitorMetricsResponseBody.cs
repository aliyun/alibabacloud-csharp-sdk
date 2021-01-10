// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchQueryRmsMonitorMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public BatchQueryRmsMonitorMetricsResponseBodyResult Result { get; set; }
        public class BatchQueryRmsMonitorMetricsResponseBodyResult : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<BatchQueryRmsMonitorMetricsResponseBodyResultList> List { get; set; }
            public class BatchQueryRmsMonitorMetricsResponseBodyResultList : TeaModel {
                public string Key { get; set; }
                public BatchQueryRmsMonitorMetricsResponseBodyResultListValue Value { get; set; }
                public class BatchQueryRmsMonitorMetricsResponseBodyResultListValue : TeaModel {
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("Datas")]
                    [Validation(Required=false)]
                    public List<BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatas> Datas { get; set; }
                    public class BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatas : TeaModel {
                        [NameInMap("Dps")]
                        [Validation(Required=false)]
                        public List<BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatasDps> Dps { get; set; }
                        public class BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatasDps : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatasTags> Tags { get; set; }
                        public class BatchQueryRmsMonitorMetricsResponseBodyResultListValueDatasTags : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                }
            }
        };

    }

}
