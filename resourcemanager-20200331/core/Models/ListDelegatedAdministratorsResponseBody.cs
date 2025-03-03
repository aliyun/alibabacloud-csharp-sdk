// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListDelegatedAdministratorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the delegated administrator accounts.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListDelegatedAdministratorsResponseBodyAccounts Accounts { get; set; }
        public class ListDelegatedAdministratorsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListDelegatedAdministratorsResponseBodyAccountsAccount> Account { get; set; }
            public class ListDelegatedAdministratorsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// <para>The ID of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>138660628348****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The time when the member was specified as a delegated administrator account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616652684164</para>
                /// </summary>
                [NameInMap("DelegationEnabledTime")]
                [Validation(Required=false)]
                public string DelegationEnabledTime { get; set; }

                /// <summary>
                /// <para>The display name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

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
                /// <para>The identifier of the trusted service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloudfw.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>009C3A02-7D4B-416C-9CE7-548C91508F1E</para>
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
        public long? TotalCount { get; set; }

    }

}
