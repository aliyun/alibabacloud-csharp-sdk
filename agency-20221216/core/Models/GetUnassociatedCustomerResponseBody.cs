// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetUnassociatedCustomerResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. Valid values:
        /// 200: OK.
        /// 1109: System error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InviteInfoList")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyInviteInfoList InviteInfoList { get; set; }
        public class GetUnassociatedCustomerResponseBodyInviteInfoList : TeaModel {
            [NameInMap("InviteInfo")]
            [Validation(Required=false)]
            public List<GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo> InviteInfo { get; set; }
            public class GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo : TeaModel {
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("InviteId")]
                [Validation(Required=false)]
                public long? InviteId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The message information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class GetUnassociatedCustomerResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number for pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud uses this ID for error tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23309219-4A34-589D-A3E0-9B2A3BFFD24F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call itself is successful. Valid values: True and False. This does not indicate the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
