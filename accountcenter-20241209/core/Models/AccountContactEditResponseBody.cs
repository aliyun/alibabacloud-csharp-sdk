// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class AccountContactEditResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data result of the current category statistics</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AccountContactEditResponseBodyData Data { get; set; }
        public class AccountContactEditResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Contact ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>Error codes.</para>
            /// </summary>
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<AccountContactEditResponseBodyDataErrorList> ErrorList { get; set; }
            public class AccountContactEditResponseBodyDataErrorList : TeaModel {
                /// <summary>
                /// <para>Error code</para>
                /// 
                /// <b>Example:</b>
                /// <para>MOBILE_CODE_ILLEGAL</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Cause of the diagnostic issue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MOBILE_CODE_ILLEGAL</para>
                /// </summary>
                [NameInMap("ErrorDesc")]
                [Validation(Required=false)]
                public string ErrorDesc { get; set; }

                /// <summary>
                /// <para>Exception field</para>
                /// 
                /// <b>Example:</b>
                /// <para>MOBILE_VERIFY_CODE</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

            }

            /// <summary>
            /// <para>Whether successful</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;TeamDesktops\&quot;: [], \&quot;PrivateDesktops\&quot;: [], \&quot;UnallocatedTeamDesktops\&quot;: []}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4E192DF-798B-58AE-B8BF-EBC15E2E85F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values: true: succeeded. false: failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
