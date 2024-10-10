// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryAliasesResponseBody : TeaModel {
        [NameInMap("AliasInfos")]
        [Validation(Required=false)]
        public QueryAliasesResponseBodyAliasInfos AliasInfos { get; set; }
        public class QueryAliasesResponseBodyAliasInfos : TeaModel {
            [NameInMap("AliasInfo")]
            [Validation(Required=false)]
            public List<QueryAliasesResponseBodyAliasInfosAliasInfo> AliasInfo { get; set; }
            public class QueryAliasesResponseBodyAliasInfosAliasInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test_alias1</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>159E4422-6624-4750-8943-DFD98D34858C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
