// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListAliasesResponseBody : TeaModel {
        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public ListAliasesResponseBodyAliases Aliases { get; set; }
        public class ListAliasesResponseBodyAliases : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<ListAliasesResponseBodyAliasesAlias> Alias { get; set; }
            public class ListAliasesResponseBodyAliasesAlias : TeaModel {
                [NameInMap("AliasArn")]
                [Validation(Required=false)]
                public string AliasArn { get; set; }

                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

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
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <para>1b57992c-834b-4811-a889-f8bac1ba0353</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned aliases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
