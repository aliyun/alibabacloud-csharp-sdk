// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferNumberResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the registered phone number.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferNumberResponseBodyData Data { get; set; }
        public class ListHotlineTransferNumberResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// The phone numbers.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListHotlineTransferNumberResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferNumberResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The China 400 number.
                /// </summary>
                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                /// <summary>
                /// The ID card number of the number owner.
                /// </summary>
                [NameInMap("IdentityCard")]
                [Validation(Required=false)]
                public string IdentityCard { get; set; }

                /// <summary>
                /// The real name of the number owner or the company name.
                /// </summary>
                [NameInMap("NumberOwnerName")]
                [Validation(Required=false)]
                public string NumberOwnerName { get; set; }

                /// <summary>
                /// The registered phone number.
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// The qualification ID.
                /// </summary>
                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public string QualificationId { get; set; }

                /// <summary>
                /// The resource code.
                /// </summary>
                [NameInMap("ResUniqueCode")]
                [Validation(Required=false)]
                public string ResUniqueCode { get; set; }

            }

        }

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

    }

}
