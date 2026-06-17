// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRdAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the accounts.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<DescribeInstanceRdAccountsResponseBodyAccounts> Accounts { get; set; }
        public class DescribeInstanceRdAccountsResponseBodyAccounts : TeaModel {
            /// <summary>
            /// <para>The ID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171054237268****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06D1EC07-C9EB-58AC-A750-C87C9A0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
