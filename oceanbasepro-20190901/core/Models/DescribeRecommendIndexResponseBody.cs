// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRecommendIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the recommended index.</para>
        /// </summary>
        [NameInMap("RecommendIndex")]
        [Validation(Required=false)]
        public DescribeRecommendIndexResponseBodyRecommendIndex RecommendIndex { get; set; }
        public class DescribeRecommendIndexResponseBodyRecommendIndex : TeaModel {
            /// <summary>
            /// <para>Example 1</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIMARY</para>
            /// </summary>
            [NameInMap("SuggestIndex")]
            [Validation(Required=false)]
            public string SuggestIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testtable</para>
            /// </summary>
            [NameInMap("TableList")]
            [Validation(Required=false)]
            public string TableList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

        }

        /// <summary>
        /// <para>The tenant mode.   Valid values:<br>Oracle<br>MySQL</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
