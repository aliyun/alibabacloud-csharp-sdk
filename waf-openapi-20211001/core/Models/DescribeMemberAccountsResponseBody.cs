// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMemberAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the member accounts.</para>
        /// </summary>
        [NameInMap("AccountInfos")]
        [Validation(Required=false)]
        public List<DescribeMemberAccountsResponseBodyAccountInfos> AccountInfos { get; set; }
        public class DescribeMemberAccountsResponseBodyAccountInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169************21</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipflgmqqnbjg</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The status of the member accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enabled</b>: The member accounts is managed.</para>
            /// </description></item>
            /// <item><description><para><b>disabled</b>: The member accounts is not managed.</para>
            /// </description></item>
            /// <item><description><para><b>disabling</b>: The member accounts is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>The description of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>descriptionTest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the member accounts was added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683367751000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50C4A80D-D46C-57E0-9A7D-03C078474852</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
