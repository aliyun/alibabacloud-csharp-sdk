// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCommercialStatusResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The commercialization status of the service.
        /// </summary>
        [NameInMap("UserAndCommodityStatus")]
        [Validation(Required=false)]
        public GetCommercialStatusResponseBodyUserAndCommodityStatus UserAndCommodityStatus { get; set; }
        public class GetCommercialStatusResponseBodyUserAndCommodityStatus : TeaModel {
            /// <summary>
            /// Indicates whether you are using the Basic Edition.
            /// </summary>
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public bool? Basic { get; set; }

            /// <summary>
            /// The billing method.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// Indicates whether the service is activated.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

            /// <summary>
            /// The number of days during which the service is free of charge.
            /// </summary>
            [NameInMap("FreeDays")]
            [Validation(Required=false)]
            public long? FreeDays { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Lable")]
            [Validation(Required=false)]
            public string Lable { get; set; }

            /// <summary>
            /// The commercialization status.
            /// 
            /// Valid values:
            /// 
            /// *   Normal: The service is activated.
            /// *   Abnormal: An exception occurs during activation.
            /// *   Free: The service is not activated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
