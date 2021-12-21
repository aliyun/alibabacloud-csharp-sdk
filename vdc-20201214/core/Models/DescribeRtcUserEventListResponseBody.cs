// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeRtcUserEventListResponseBody : TeaModel {
        /// <summary>
        /// 指标列表
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeRtcUserEventListResponseBodyEvents> Events { get; set; }
        public class DescribeRtcUserEventListResponseBodyEvents : TeaModel {
            /// <summary>
            /// 事件类型
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 事件Id
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public int? EventId { get; set; }

            /// <summary>
            /// 时间发生unix timestamp
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
