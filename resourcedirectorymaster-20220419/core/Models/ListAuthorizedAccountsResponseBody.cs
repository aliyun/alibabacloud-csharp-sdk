// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAuthorizedAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the member.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListAuthorizedAccountsResponseBodyAccounts Accounts { get; set; }
        public class ListAuthorizedAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListAuthorizedAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class ListAuthorizedAccountsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>184311716100****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The display name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fd-bVaRIG****</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>The way in which the member joins the resource directory. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>invited: The member is invited to join the resource directory.</description></item>
                /// <item><description>created: The member is directly created in the resource directory.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>created</para>
                /// </summary>
                [NameInMap("JoinMethod")]
                [Validation(Required=false)]
                public string JoinMethod { get; set; }

                /// <summary>
                /// <para>The time when the member joined the resource directory. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public string JoinTime { get; set; }

                /// <summary>
                /// <para>The time when the member was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The ID of the resource directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rd-k4****</para>
                /// </summary>
                [NameInMap("ResourceDirectoryId")]
                [Validation(Required=false)]
                public string ResourceDirectoryId { get; set; }

                /// <summary>
                /// <para>The RDPath of the member.</para>
                /// </summary>
                [NameInMap("ResourceDirectoryPath")]
                [Validation(Required=false)]
                public string ResourceDirectoryPath { get; set; }

                /// <summary>
                /// <para>The status of the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CreateSuccess: The member is created.</description></item>
                /// <item><description>PromoteVerifying: The upgrade of the member is under confirmation.</description></item>
                /// <item><description>PromoteFailed: The upgrade of the member fails.</description></item>
                /// <item><description>PromoteExpired: The upgrade of the member expires.</description></item>
                /// <item><description>PromoteCancelled: The upgrade of the member is canceled.</description></item>
                /// <item><description>PromoteSuccess: The member is upgraded.</description></item>
                /// <item><description>InviteSuccess: The member accepts the invitation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CreateSuccess</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CloudAccount: cloud account</description></item>
                /// <item><description>ResourceAccount: resource account</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ResourceAccount</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
