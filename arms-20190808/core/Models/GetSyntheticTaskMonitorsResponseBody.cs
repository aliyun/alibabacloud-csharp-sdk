// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskMonitorsResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// 
        /// *   1001: The request was successful.
        /// *   1002: The request failed.
        /// *   1003: Parameter errors occurred.
        /// *   1004: Authentication failed.
        /// *   1006: The task does not exist.
        /// *   1099: Internal errors occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the monitoring point.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyntheticTaskMonitorsResponseBodyData> Data { get; set; }
        public class GetSyntheticTaskMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// The task status.
            /// 
            /// *   0: active
            /// *   1: busy
            /// </summary>
            [NameInMap("Busy")]
            [Validation(Required=false)]
            public long? Busy { get; set; }

            /// <summary>
            /// The name of the city to which the monitoring point belongs.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The ID of the city to which the monitoring point belongs.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            /// <summary>
            /// The client type:
            /// 
            /// *   1: IDC
            /// *   2: Last mile
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public long? ClientType { get; set; }

            /// <summary>
            /// The region to which the monitoring point belongs.
            /// </summary>
            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// The ID of the carrier.
            /// </summary>
            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

            /// <summary>
            /// The name of the carrier.
            /// </summary>
            [NameInMap("NetServiceName")]
            [Validation(Required=false)]
            public string NetServiceName { get; set; }

        }

        /// <summary>
        /// The message that is returned when the request failed.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
