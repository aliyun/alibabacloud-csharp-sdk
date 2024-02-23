// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferRegisterFileResponseBody : TeaModel {
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
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferRegisterFileResponseBodyData Data { get; set; }
        public class ListHotlineTransferRegisterFileResponseBodyData : TeaModel {
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
            /// The registration file.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListHotlineTransferRegisterFileResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferRegisterFileResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The authenticity of the commitment.
                /// </summary>
                [NameInMap("Agree")]
                [Validation(Required=false)]
                public string Agree { get; set; }

                /// <summary>
                /// The enterprise name.
                /// </summary>
                [NameInMap("CorpName")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// The China 400 number.
                /// </summary>
                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                /// <summary>
                /// The ID card number of the handler.
                /// </summary>
                [NameInMap("MngOpIdentityCard")]
                [Validation(Required=false)]
                public string MngOpIdentityCard { get; set; }

                /// <summary>
                /// The email address of the handler.
                /// </summary>
                [NameInMap("MngOpMail")]
                [Validation(Required=false)]
                public string MngOpMail { get; set; }

                /// <summary>
                /// The mobile phone number of the handler.
                /// </summary>
                [NameInMap("MngOpMobile")]
                [Validation(Required=false)]
                public string MngOpMobile { get; set; }

                /// <summary>
                /// The name of the handler.
                /// </summary>
                [NameInMap("MngOpName")]
                [Validation(Required=false)]
                public string MngOpName { get; set; }

                /// <summary>
                /// The qualification ID.
                /// </summary>
                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public string QualificationId { get; set; }

                /// <summary>
                /// The unique code of the query operation.
                /// </summary>
                [NameInMap("ResUniqueCode")]
                [Validation(Required=false)]
                public long? ResUniqueCode { get; set; }

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
