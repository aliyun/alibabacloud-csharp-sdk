// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyData Data { get; set; }
        public class DescribeAccountsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The database accounts.</para>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyDataAccounts> Accounts { get; set; }
            public class DescribeAccountsResponseBodyDataAccounts : TeaModel {
                /// <summary>
                /// <para>The username of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <para>The type of the database account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: standard account</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: privileged account</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>For testing</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The state of the database account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: The database account is being created.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: The database account is in use.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: The database account is being deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
            /// <para>The number of entries per page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>30</b> (default)</para>
            /// </description></item>
            /// <item><description><para><b>50</b></para>
            /// </description></item>
            /// <item><description><para><b>100</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
