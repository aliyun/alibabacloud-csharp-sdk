// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASRequest : TeaModel {
        /// <summary>
        /// The security authentication method of the API. Valid values:
        /// 
        /// *   **APP: Only authorized applications can call the API.**
        /// 
        /// *   **ANONYMOUS: The API can be anonymously called. In this mode, you must take note of the following rules:**
        /// 
        ///     *   All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The name of the backend service.
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// The OAS-compliant text file or OSS object URL.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the API group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Specifies whether to ignore alerts.
        /// </summary>
        [NameInMap("IgnoreWarning")]
        [Validation(Required=false)]
        public bool? IgnoreWarning { get; set; }

        /// <summary>
        /// The OAS version.
        /// </summary>
        [NameInMap("OASVersion")]
        [Validation(Required=false)]
        public string OASVersion { get; set; }

        /// <summary>
        /// Specifies whether to overwrite an existing API.
        /// 
        /// If an existing API has the same HTTP request type and backend request path as the API to be imported, the existing API is overwritten.
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// The request mode. Valid values:
        /// 
        /// *   MAPPING: Parameters are mapped. Unknown parameters are filtered out.
        /// *   PASSTHROUGH: Parameters are passed through.
        /// </summary>
        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Specifies whether to directly import the API without performing a precheck.
        /// </summary>
        [NameInMap("SkipDryRun")]
        [Validation(Required=false)]
        public bool? SkipDryRun { get; set; }

    }

}
