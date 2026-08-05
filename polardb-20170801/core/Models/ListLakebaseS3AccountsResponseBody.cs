// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListLakebaseS3AccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of S3 accounts.</para>
        /// </summary>
        [NameInMap("S3Accounts")]
        [Validation(Required=false)]
        public List<ListLakebaseS3AccountsResponseBodyS3Accounts> S3Accounts { get; set; }
        public class ListLakebaseS3AccountsResponseBodyS3Accounts : TeaModel {
            /// <summary>
            /// <para>The account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: the built-in default account.</description></item>
            /// <item><description>user: a user-created account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The access key of the S3 account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accname</para>
            /// </summary>
            [NameInMap("UserAccAk")]
            [Validation(Required=false)]
            public string UserAccAk { get; set; }

            /// <summary>
            /// <para>The secret key of the S3 account (displayed in masked format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>password***</para>
            /// </summary>
            [NameInMap("UserAccSk")]
            [Validation(Required=false)]
            public string UserAccSk { get; set; }

        }

        /// <summary>
        /// <para>The total number of accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
