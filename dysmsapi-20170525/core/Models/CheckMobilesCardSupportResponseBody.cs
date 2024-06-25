// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CheckMobilesCardSupportResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckMobilesCardSupportResponseBodyData Data { get; set; }
        public class CheckMobilesCardSupportResponseBodyData : TeaModel {
            /// <summary>
            /// The list of returned results.
            /// </summary>
            [NameInMap("queryResult")]
            [Validation(Required=false)]
            public List<CheckMobilesCardSupportResponseBodyDataQueryResult> QueryResult { get; set; }
            public class CheckMobilesCardSupportResponseBodyDataQueryResult : TeaModel {
                /// <summary>
                /// The mobile phone number.
                /// </summary>
                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// Indicates whether the mobile phone number supports card messages.
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
