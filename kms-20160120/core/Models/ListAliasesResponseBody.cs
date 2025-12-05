// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListAliasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The alias of the user.</para>
        /// </summary>
        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public ListAliasesResponseBodyAliases Aliases { get; set; }
        public class ListAliasesResponseBodyAliases : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<ListAliasesResponseBodyAliasesAlias> Alias { get; set; }
            public class ListAliasesResponseBodyAliasesAlias : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:kms:cn-hangzhou:123456:alias/ExampleAlias1</para>
                /// </summary>
                [NameInMap("AliasArn")]
                [Validation(Required=false)]
                public string AliasArn { get; set; }

                /// <summary>
                /// <para>The ID of the alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alias/ExampleAlias1</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>The CMK to which the alias belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d****</para>
                /// </summary>
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
        /// <para>The ID of the request.</para>
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
