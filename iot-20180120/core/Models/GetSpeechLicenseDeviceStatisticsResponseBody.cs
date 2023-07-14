// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSpeechLicenseDeviceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSpeechLicenseDeviceStatisticsResponseBodyData Data { get; set; }
        public class GetSpeechLicenseDeviceStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of available licenses.
            /// </summary>
            [NameInMap("AvailableQuota")]
            [Validation(Required=false)]
            public int? AvailableQuota { get; set; }

            /// <summary>
            /// The number of expired licenses.
            /// </summary>
            [NameInMap("ExpiredQuota")]
            [Validation(Required=false)]
            public int? ExpiredQuota { get; set; }

            /// <summary>
            /// The number of licenses that are about to expire.
            /// </summary>
            [NameInMap("ExpiringQuota")]
            [Validation(Required=false)]
            public int? ExpiringQuota { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
