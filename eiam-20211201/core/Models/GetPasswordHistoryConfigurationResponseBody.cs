// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordHistoryConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The password history configurations.
        /// </summary>
        [NameInMap("PasswordHistoryConfiguration")]
        [Validation(Required=false)]
        public GetPasswordHistoryConfigurationResponseBodyPasswordHistoryConfiguration PasswordHistoryConfiguration { get; set; }
        public class GetPasswordHistoryConfigurationResponseBodyPasswordHistoryConfiguration : TeaModel {
            /// <summary>
            /// The maximum number of recent passwords that are retained.
            /// </summary>
            [NameInMap("PasswordHistoryMaxRetention")]
            [Validation(Required=false)]
            public int? PasswordHistoryMaxRetention { get; set; }

            /// <summary>
            /// Indicates whether the password history feature is enabled. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// </summary>
            [NameInMap("PasswordHistoryStatus")]
            [Validation(Required=false)]
            public string PasswordHistoryStatus { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
