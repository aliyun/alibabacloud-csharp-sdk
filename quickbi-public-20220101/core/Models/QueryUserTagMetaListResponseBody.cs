// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserTagMetaListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserTagMetaListResponseBodyResult> Result { get; set; }
        public class QueryUserTagMetaListResponseBodyResult : TeaModel {
            [NameInMap("TagDescription")]
            [Validation(Required=false)]
            public string TagDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pop_001</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>Queries the metadata list of member tags in an organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
