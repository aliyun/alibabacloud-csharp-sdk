// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListAliasesByKeyIdResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of aliases.
        /// </summary>
        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public ListAliasesByKeyIdResponseBodyAliases Aliases { get; set; }
        public class ListAliasesByKeyIdResponseBodyAliases : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<ListAliasesByKeyIdResponseBodyAliasesAlias> Alias { get; set; }
            public class ListAliasesByKeyIdResponseBodyAliasesAlias : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the alias.
                /// </summary>
                [NameInMap("AliasArn")]
                [Validation(Required=false)]
                public string AliasArn { get; set; }

                /// <summary>
                /// The ID of the alias.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The CMK to which an alias is bound.
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned CMKs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
