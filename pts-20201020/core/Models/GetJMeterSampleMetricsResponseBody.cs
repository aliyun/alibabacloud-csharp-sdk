// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterSampleMetricsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 采样器聚合数据列表
        /// </summary>
        [NameInMap("SampleMetricList")]
        [Validation(Required=false)]
        public List<string> SampleMetricList { get; set; }

        /// <summary>
        /// 采样器列表，可根据该列表传递需要查询的采样器
        /// </summary>
        [NameInMap("SamplerMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SamplerMap { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
