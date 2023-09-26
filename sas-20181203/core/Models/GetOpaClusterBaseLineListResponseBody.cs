// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaClusterBaseLineListResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about baselines.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOpaClusterBaseLineListResponseBodyData> Data { get; set; }
        public class GetOpaClusterBaseLineListResponseBodyData : TeaModel {
            /// <summary>
            /// The alias of the baseline.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The key of the baseline type.
            /// </summary>
            [NameInMap("ClassKey")]
            [Validation(Required=false)]
            public string ClassKey { get; set; }

            /// <summary>
            /// The key of the name for the baseline check item.
            /// </summary>
            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

            /// <summary>
            /// The key of the name for the baseline.
            /// </summary>
            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
