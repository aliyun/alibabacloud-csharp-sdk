// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMemberAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the member.</para>
        /// </summary>
        [NameInMap("AccountInfos")]
        [Validation(Required=false)]
        public List<DescribeMemberAccountsResponseBodyAccountInfos> AccountInfos { get; set; }
        public class DescribeMemberAccountsResponseBodyAccountInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169************21</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipflgmqqnbjg</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The status of the member.</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: managed.</description></item>
            /// <item><description><b>disabled</b>: not managed.</description></item>
            /// <item><description><b>disabling</b>: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>The description of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the member was added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683367751000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50C4A80D-D46C-57E0-9A7D-03C0****4852</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
