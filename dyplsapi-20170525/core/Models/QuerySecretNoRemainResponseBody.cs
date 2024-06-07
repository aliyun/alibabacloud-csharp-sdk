// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoRemainResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other status codes indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/109196.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
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

        /// <summary>
        /// The information returned after the operation was called.
        /// </summary>
        [NameInMap("SecretRemainDTO")]
        [Validation(Required=false)]
        public QuerySecretNoRemainResponseBodySecretRemainDTO SecretRemainDTO { get; set; }
        public class QuerySecretNoRemainResponseBodySecretRemainDTO : TeaModel {
            /// <summary>
            /// The quantity of remaining phone numbers available for online purchase.
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// The home location of the phone numbers.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The information about remaining phone numbers available for online purchase.
            /// </summary>
            [NameInMap("RemainDTOList")]
            [Validation(Required=false)]
            public QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList RemainDTOList { get; set; }
            public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList : TeaModel {
                [NameInMap("remainDTO")]
                [Validation(Required=false)]
                public List<QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO> RemainDTO { get; set; }
                public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO : TeaModel {
                    /// <summary>
                    /// The quantity of remaining phone numbers available for online purchase for the city.
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// The home location of the phone numbers.
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                }

            }

        }

    }

}
