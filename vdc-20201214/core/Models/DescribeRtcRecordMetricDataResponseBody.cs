// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeRtcRecordMetricDataResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 录制用量查询数据
        /// </summary>
        [NameInMap("RtcRecordMetricData")]
        [Validation(Required=false)]
        public List<DescribeRtcRecordMetricDataResponseBodyRtcRecordMetricData> RtcRecordMetricData { get; set; }
        public class DescribeRtcRecordMetricDataResponseBodyRtcRecordMetricData : TeaModel {
            /// <summary>
            /// 时长分钟
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 分辨率
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

            /// <summary>
            /// 服务区域
            /// </summary>
            [NameInMap("ServiceArea")]
            [Validation(Required=false)]
            public string ServiceArea { get; set; }

            /// <summary>
            /// 规格
            /// </summary>
            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

            /// <summary>
            /// 日期，UTC格式
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// 输入路数
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
