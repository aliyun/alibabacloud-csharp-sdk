// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetEngineNamepaceResponseBody : TeaModel {
        /// <summary>
        /// The number of configurations.
        /// </summary>
        [NameInMap("ConfigCount")]
        [Validation(Required=false)]
        public string ConfigCount { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The description of the namespace.
        /// </summary>
        [NameInMap("NamespaceDesc")]
        [Validation(Required=false)]
        public string NamespaceDesc { get; set; }

        /// <summary>
        /// The display name of the namespace.
        /// </summary>
        [NameInMap("NamespaceShowName")]
        [Validation(Required=false)]
        public string NamespaceShowName { get; set; }

        /// <summary>
        /// The quota of configurations.
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The type of the namespace. Valid values:
        /// 
        /// *   0: global configuration
        /// *   1: default namespace
        /// *   2: custom namespace
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
