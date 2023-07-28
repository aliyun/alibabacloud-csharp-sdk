// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataResponseBody : TeaModel {
        /// <summary>
        /// The details of the invalid parameters.
        /// 
        /// If the request parameters that you set are invalid, the details of the invalid parameters are displayed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// For more information about common request parameters, see [Common parameters](~~199331~~).
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataResponseBodyErrorDetail> ErrorDetail { get; set; }
        public class PutHybridMonitorMetricDataResponseBodyErrorDetail : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
