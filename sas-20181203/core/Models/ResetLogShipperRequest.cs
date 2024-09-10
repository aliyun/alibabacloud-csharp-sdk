// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ResetLogShipperRequest : TeaModel {
        /// <summary>
        /// The global retention period of hot data.
        /// 
        /// >  The value of this parameter must be at least 7 and smaller than the log retention period. Unit: days.
        /// </summary>
        [NameInMap("HotTtl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// The settings of the log analysis feature.
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<ResetLogShipperRequestLogMetaList> LogMetaList { get; set; }
        public class ResetLogShipperRequestLogMetaList : TeaModel {
            /// <summary>
            /// The Logstore that you want to configure.
            /// 
            /// >  You can call the [DescribeLogMeta](~~DescribeLogMeta~~) operation to query the Logstore.
            /// </summary>
            [NameInMap("ConfigLogStore")]
            [Validation(Required=false)]
            public string ConfigLogStore { get; set; }

            /// <summary>
            /// The retention period of hot data in the Logstore.
            /// 
            /// >  The value of this parameter must be at least 7 and smaller than the log retention period. Unit: days. If you specify this parameter for the Logstore, the global retention period of hot data specified by the HotTtl parameter is overwritten.
            /// </summary>
            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            /// <summary>
            /// The status of the log analysis feature. Valid values:
            /// 
            /// *   **disabled**
            /// *   **enabled**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The log retention period of the Logstore.
            /// 
            /// >  If you specify this parameter for the Logstore, the global log retention period specified by the Ttl parameter is overwritten.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// The global log retention period.
        /// 
        /// >  This parameter is supported only when the log analysis feature uses the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
