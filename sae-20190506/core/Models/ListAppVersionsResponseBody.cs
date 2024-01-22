// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppVersionsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the historical versions of the application were obtained. Valid values:
        /// 
        /// *   **true**: indicates that the historical versions of the application were obtained.
        /// *   **false**: indicates that the historical versions of the application could not be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The deployment method of the application. Valid values:
        /// 
        /// *   **image**: indicates that the application was deployed by using an image.
        /// *   **upload**: indicates that the application was deployed by uploading a WAR or JAR package.
        /// *   **url**: indicates that the application was deployed by specifying the URL of a WAR or JAR package.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppVersionsResponseBodyData> Data { get; set; }
        public class ListAppVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// *   The address of the image. This parameter is returned when the **Type** parameter is set to **image**.
            /// *   The download link of the WAR or JAR package. This parameter is returned when the **Type** parameter is set to **upload**.
            /// </summary>
            [NameInMap("BuildPackageUrl")]
            [Validation(Required=false)]
            public string BuildPackageUrl { get; set; }

            /// <summary>
            /// The download link of the WAR or JAR package. This parameter is returned when the **Type** parameter is set to **url**.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The time when the application was created.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("WarUrl")]
            [Validation(Required=false)]
            public string WarUrl { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about the versions.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
