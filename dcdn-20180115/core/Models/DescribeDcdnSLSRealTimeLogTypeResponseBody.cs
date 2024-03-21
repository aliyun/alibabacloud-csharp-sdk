// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSLSRealTimeLogTypeResponseBody : TeaModel {
        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnSLSRealTimeLogTypeResponseBodyContent Content { get; set; }
        public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContent : TeaModel {
            [NameInMap("Business")]
            [Validation(Required=false)]
            public List<DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness> Business { get; set; }
            public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness : TeaModel {
                /// <summary>
                /// The type of real-time logs. Valid values:
                /// 
                /// *   **dcdn_log_access_l1**: access logs.
                /// *   **dcdn_log_er**: EdgeRoutine logs
                /// *   **dcdn_log_waf**: WAF interception logs
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// The description of the real-time log type.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
