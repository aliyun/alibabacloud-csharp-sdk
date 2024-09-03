// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetFlowResponseBody : TeaModel {
        /// <summary>
        /// If OK is returned, the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFlowResponseBodyData Data { get; set; }
        public class GetFlowResponseBodyData : TeaModel {
            /// <summary>
            /// The categories of the Flow.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// The version number of the API.
            /// </summary>
            [NameInMap("DataApiVersion")]
            [Validation(Required=false)]
            public string DataApiVersion { get; set; }

            /// <summary>
            /// The Flow ID.
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// The Flow name.
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// The JSON version.
            /// </summary>
            [NameInMap("JSONVersion")]
            [Validation(Required=false)]
            public string JSONVersion { get; set; }

            /// <summary>
            /// The temporary preview URL.
            /// </summary>
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// The time when the preview URL expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("PreviewUrlExpires")]
            [Validation(Required=false)]
            public long? PreviewUrlExpires { get; set; }

            /// <summary>
            /// The state of the Flow.
            /// 
            /// Valid values:
            /// 
            /// *   PUBLISHED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   DRAFT
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   DEPRECATED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The error message.
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

    }

}
