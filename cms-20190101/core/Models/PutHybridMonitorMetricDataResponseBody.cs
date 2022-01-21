// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataResponseBody : TeaModel {
        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 不合法的指标信息
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataResponseBodyErrorDetail> ErrorDetail { get; set; }
        public class PutHybridMonitorMetricDataResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// 错误数据在上报列表中的序号，从0开始
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// 请求的requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
