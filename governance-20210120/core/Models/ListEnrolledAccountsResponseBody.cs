// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEnrolledAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The accounts.</para>
        /// </summary>
        [NameInMap("EnrolledAccounts")]
        [Validation(Required=false)]
        public List<ListEnrolledAccountsResponseBodyEnrolledAccounts> EnrolledAccounts { get; set; }
        public class ListEnrolledAccountsResponseBodyEnrolledAccounts : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19534534552*****</para>
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>afb-bp1durvn3lgqe28v****</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            /// <summary>
            /// <para>The time at which the account was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T02:38:27Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The display name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestAccount</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the parent folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-5ESoku****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The ID of the billing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13161210500*****</para>
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

            /// <summary>
            /// <para>The creation status of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The account is waiting to be created.</description></item>
            /// <item><description>Running: The account is being created.</description></item>
            /// <item><description>Finished: The account is created.</description></item>
            /// <item><description>Failed: The account failed to be created.</description></item>
            /// <item><description>Scheduling: The account is being scheduled.</description></item>
            /// <item><description>ScheduleFailed: The account failed to be scheduled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the information about the account was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T02:38:27Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAALHWGpGoYCcYMxiFfmlhvh62Xr2DzYbz/SAfc*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>768F908D-A66A-5A5D-816C-20C93CBBFEE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
