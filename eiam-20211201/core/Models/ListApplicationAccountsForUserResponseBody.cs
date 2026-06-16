// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationAccountsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the member accounts.</para>
        /// </summary>
        [NameInMap("ApplicationAccounts")]
        [Validation(Required=false)]
        public List<ListApplicationAccountsForUserResponseBodyApplicationAccounts> ApplicationAccounts { get; set; }
        public class ListApplicationAccountsForUserResponseBodyApplicationAccounts : TeaModel {
            /// <summary>
            /// <para>The application account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aac_m6e3ukegwvbcb2fne7j32xxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationAccountId")]
            [Validation(Required=false)]
            public string ApplicationAccountId { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_na2r76irswrwfgpkz7xvcj7xxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the application account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApplicationUsername")]
            [Validation(Required=false)]
            public string ApplicationUsername { get; set; }

            /// <summary>
            /// <para>The time when the account was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754359439000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the IDaaS EIAM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ki6hd7ihir4ybawogqk6xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_tkmboufpnvpbitdpzrlng6mxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
