// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationClientSecretsResponseBody : TeaModel {
        /// <summary>
        /// The information about the client keys.
        /// </summary>
        [NameInMap("ApplicationClientSecrets")]
        [Validation(Required=false)]
        public List<ListApplicationClientSecretsResponseBodyApplicationClientSecrets> ApplicationClientSecrets { get; set; }
        public class ListApplicationClientSecretsResponseBodyApplicationClientSecrets : TeaModel {
            /// <summary>
            /// The ID of the application that you want to query.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// The client ID of the application.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The client key secret of the application. The value is not masked.
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the client key was last used. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// The client key ID of the application.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// The status of the client key. Valid values:
            /// 
            /// *   Enabled: The client key is enabled.
            /// *   Disabled: The client key is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
