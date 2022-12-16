// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetNacosHistoryConfigResponseBody : TeaModel {
        /// <summary>
        /// The information about the configuration.
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public GetNacosHistoryConfigResponseBodyConfiguration Configuration { get; set; }
        public class GetNacosHistoryConfigResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The content of the configuration.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The ID of the configuration.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The encryption key.
            /// </summary>
            [NameInMap("EncryptedDataKey")]
            [Validation(Required=false)]
            public string EncryptedDataKey { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The MD5 value of the configuration.
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// The type of the configuration.
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
