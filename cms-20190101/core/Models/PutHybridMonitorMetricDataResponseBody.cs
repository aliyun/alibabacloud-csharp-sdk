// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of invalid parameters.
        /// 
        /// If a request parameter is invalid, the details of the invalid parameter are returned.
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataResponseBodyErrorDetail> ErrorDetail { get; set; }
        public class PutHybridMonitorMetricDataResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// The error message of the invalid parameter.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The position of the error message in the array.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
