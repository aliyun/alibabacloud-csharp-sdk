// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseRegionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseRegionResponseBodyData Data { get; set; }
        public class GetDoctorHBaseRegionResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseRegionResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseRegionResponseBodyDataMetrics : TeaModel {
                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsDailyReadRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsDailyWriteRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsStoreFileCount : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsTotalReadRequest TotalReadRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsTotalReadRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionResponseBodyDataMetricsTotalWriteRequest TotalWriteRequest { get; set; }
                public class GetDoctorHBaseRegionResponseBodyDataMetricsTotalWriteRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

            [NameInMap("RegionServerHost")]
            [Validation(Required=false)]
            public string RegionServerHost { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
