// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateHookConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the mounted script.
        /// </summary>
        [NameInMap("HooksConfiguration")]
        [Validation(Required=false)]
        public List<UpdateHookConfigurationResponseBodyHooksConfiguration> HooksConfiguration { get; set; }
        public class UpdateHookConfigurationResponseBodyHooksConfiguration : TeaModel {
            /// <summary>
            /// Indicates whether a mount failure is ignored. Valid values:
            /// 
            /// *   **true**: A mount failure is ignored.
            /// *   **false**: A mount failure is not ignored.
            /// </summary>
            [NameInMap("IgnoreFail")]
            [Validation(Required=false)]
            public bool? IgnoreFail { get; set; }

            /// <summary>
            /// The name of the mounted script.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The content of the mounted script.
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// The message that is returned.
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

    }

}
