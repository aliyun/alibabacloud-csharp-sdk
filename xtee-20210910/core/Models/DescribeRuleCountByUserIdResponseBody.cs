// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleCountByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRuleCountByUserIdResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRuleCountByUserIdResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Indicates whether the limit condition is reached. Valid values: - <b>true</b>: The limit condition is reached. - <b>false</b>: The limit condition is not reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public bool? Limit { get; set; }

            /// <summary>
            /// <para>The maximum number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("maxTotalItem")]
            [Validation(Required=false)]
            public int? MaxTotalItem { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public int? TotalItem { get; set; }

        }

    }

}
