// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserTagMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of user tags in the organization.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserTagMetaListResponseBodyResult> Result { get; set; }
        public class QueryUserTagMetaListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The tag description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to distinguish certain positions</para>
            /// </summary>
            [NameInMap("TagDescription")]
            [Validation(Required=false)]
            public string TagDescription { get; set; }

            /// <summary>
            /// <para>The tag ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pop_001</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Position</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
