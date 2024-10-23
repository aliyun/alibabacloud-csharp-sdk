// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAllAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried database accounts.</para>
        /// </summary>
        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public List<DescribeAllAccountsResponseBodyAccountList> AccountList { get; set; }
        public class DescribeAllAccountsResponseBodyAccountList : TeaModel {
            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rdsdt_dts_adb</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
