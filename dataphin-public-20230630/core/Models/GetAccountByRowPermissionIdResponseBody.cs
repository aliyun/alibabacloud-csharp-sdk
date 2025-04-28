// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAccountByRowPermissionIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAccountByRowPermissionIdResponseBodyData> Data { get; set; }
        public class GetAccountByRowPermissionIdResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>300001235</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("UserMappingList")]
            [Validation(Required=false)]
            public List<GetAccountByRowPermissionIdResponseBodyDataUserMappingList> UserMappingList { get; set; }
            public class GetAccountByRowPermissionIdResponseBodyDataUserMappingList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PERSONAL</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public List<GetAccountByRowPermissionIdResponseBodyDataUserMappingListAccounts> Accounts { get; set; }
                public class GetAccountByRowPermissionIdResponseBodyDataUserMappingListAccounts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300901111</para>
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public string AccountId { get; set; }

                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
