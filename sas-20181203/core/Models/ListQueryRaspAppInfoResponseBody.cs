// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListQueryRaspAppInfoResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The installation information of the RASP-enabled application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListQueryRaspAppInfoResponseBodyData> Data { get; set; }
        public class ListQueryRaspAppInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the RASP-enabled application.
            /// </summary>
            [NameInMap("RaspAppName")]
            [Validation(Required=false)]
            public string RaspAppName { get; set; }

            /// <summary>
            /// The online status of the RASP-enabled applications. Valid values:
            /// 
            /// *   **0**: All RASP-enabled applications are online.
            /// *   **1**: Part of the RASP-enabled applications are online.
            /// *   **2**: All RASP-enabled applications are offline.
            /// </summary>
            [NameInMap("RaspOnlineStatus")]
            [Validation(Required=false)]
            public int? RaspOnlineStatus { get; set; }

            /// <summary>
            /// The installation status of the RASP-enabled application. Valid values:
            /// 
            /// *   **SUCCESS**: The RASP-enabled application is installed.
            /// *   **FAIL**: The RASP-enabled application fails to be installed.
            /// *   **INSTALL**: The RASP-enabled application is being installed.
            /// </summary>
            [NameInMap("RaspStatus")]
            [Validation(Required=false)]
            public string RaspStatus { get; set; }

            /// <summary>
            /// The result returned if the push fails.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
