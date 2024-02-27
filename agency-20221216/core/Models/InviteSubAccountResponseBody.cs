// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubAccountResponseBody : TeaModel {
        /// <summary>
        /// Error Code: </br>
        /// • 200 OK</br>
        /// • 1109 System Error</br>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Message</br>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Request ID, Alibaba Cloud will track errors with this ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List of invitation sending results
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public InviteSubAccountResponseBodyResults Results { get; set; }
        public class InviteSubAccountResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<InviteSubAccountResponseBodyResultsResult> Result { get; set; }
            public class InviteSubAccountResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// Error Code, 200 OK
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// Message, Notes of Code
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Returning Message of Invitation Results
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public InviteSubAccountResponseBodyResultsResultResult Result { get; set; }
                public class InviteSubAccountResponseBodyResultsResultResult : TeaModel {
                    /// <summary>
                    /// Valid days of registration URL, count on daily basis.
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    /// <summary>
                    /// Invitation ID, The invitation status tracking code.
                    /// </summary>
                    [NameInMap("InviteId")]
                    [Validation(Required=false)]
                    public long? InviteId { get; set; }

                    /// <summary>
                    /// URL for Partner Customer Registration.
                    /// </summary>
                    [NameInMap("RegUrl")]
                    [Validation(Required=false)]
                    public string RegUrl { get; set; }

                }

                /// <summary>
                /// Always true.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// Candidate Values: True/False, this value states if the current API calling action is successful. It does not guarantee the success of subsequent business operations.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
