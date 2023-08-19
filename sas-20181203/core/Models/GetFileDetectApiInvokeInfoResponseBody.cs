// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectApiInvokeInfoResponseBody : TeaModel {
        /// <summary>
        /// Returns the response body.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectApiInvokeInfoResponseBodyData Data { get; set; }
        public class GetFileDetectApiInvokeInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of authorizations.
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public long? AuthCount { get; set; }

            /// <summary>
            /// The timestamp of the expiration date of the authorization number.
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// The frequency of calls.
            /// </summary>
            [NameInMap("FlowRate")]
            [Validation(Required=false)]
            public int? FlowRate { get; set; }

            /// <summary>
            /// The number of remaining authorizations.
            /// </summary>
            [NameInMap("RemainAuthCount")]
            [Validation(Required=false)]
            public long? RemainAuthCount { get; set; }

            /// <summary>
            /// The Authorized Version. Valid values include:
            /// 
            /// * **1:** trial version
            /// * **2:** Enterprise Edition
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public int? SaleVersion { get; set; }

            /// <summary>
            /// The time unit of the frequency limit. Value:
            /// 
            /// * **SECONDS**
            /// * **MINUTES**
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
