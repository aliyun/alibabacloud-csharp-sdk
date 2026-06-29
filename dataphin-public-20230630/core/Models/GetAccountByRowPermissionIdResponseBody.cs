// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAccountByRowPermissionIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAccountByRowPermissionIdResponseBodyData> Data { get; set; }
        public class GetAccountByRowPermissionIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The row-level permission rule IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001235</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The accounts associated with the rule.</para>
            /// </summary>
            [NameInMap("UserMappingList")]
            [Validation(Required=false)]
            public List<GetAccountByRowPermissionIdResponseBodyDataUserMappingList> UserMappingList { get; set; }
            public class GetAccountByRowPermissionIdResponseBodyDataUserMappingList : TeaModel {
                /// <summary>
                /// <para>The type of the account associated with the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PERSONAL</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The accounts associated with the rule.</para>
                /// </summary>
                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public List<GetAccountByRowPermissionIdResponseBodyDataUserMappingListAccounts> Accounts { get; set; }
                public class GetAccountByRowPermissionIdResponseBodyDataUserMappingListAccounts : TeaModel {
                    /// <summary>
                    /// <para>The ID of the account associated with the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300901111</para>
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public string AccountId { get; set; }

                    /// <summary>
                    /// <para>The name of the account associated with the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
