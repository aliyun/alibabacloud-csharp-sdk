// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSUGIResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHDFSUGIResponseBodyData Data { get; set; }
        public class GetDoctorHDFSUGIResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHDFSUGIResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHDFSUGIResponseBodyDataMetrics : TeaModel {
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize : TeaModel {
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

                [NameInMap("TotalDirCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount TotalDirCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount : TeaModel {
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

                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount : TeaModel {
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

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
