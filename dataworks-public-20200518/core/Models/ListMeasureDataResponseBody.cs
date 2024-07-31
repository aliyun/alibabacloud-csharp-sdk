// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMeasureDataResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The measurement results.
        /// </summary>
        [NameInMap("MeasureDatas")]
        [Validation(Required=false)]
        public List<ListMeasureDataResponseBodyMeasureDatas> MeasureDatas { get; set; }
        public class ListMeasureDataResponseBodyMeasureDatas : TeaModel {
            /// <summary>
            /// The measurement component.
            /// </summary>
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            /// <summary>
            /// The item that is measured.
            /// </summary>
            [NameInMap("DomainCode")]
            [Validation(Required=false)]
            public string DomainCode { get; set; }

            /// <summary>
            /// The end timestamp of the measurement period, in milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The start timestamp of the measurement period, in milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The total quantity used within the measurement period.
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public long? Usage { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
