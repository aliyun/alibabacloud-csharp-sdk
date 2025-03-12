// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOutlineBindingResponseBody : TeaModel {
        /// <summary>
        /// <para>The binding information.</para>
        /// </summary>
        [NameInMap("OutlineBinding")]
        [Validation(Required=false)]
        public DescribeOutlineBindingResponseBodyOutlineBinding OutlineBinding { get; set; }
        public class DescribeOutlineBindingResponseBodyOutlineBinding : TeaModel {
            /// <summary>
            /// <para>The bound index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIMARY</para>
            /// </summary>
            [NameInMap("BindIndex")]
            [Validation(Required=false)]
            public string BindIndex { get; set; }

            /// <summary>
            /// <para>The bound plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHY_TABLE_SCAN | bmsql_order_line | 40 ******</para>
            /// </summary>
            [NameInMap("BindPlan")]
            [Validation(Required=false)]
            public string BindPlan { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public int? MaxConcurrent { get; set; }

            /// <summary>
            /// <para>OutlineID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// <para>The name of the tenant. The tenant name must start with a letter or an underscore (<em>), and contain 2 to 20 characters, which can be uppercase letters, lowercase letters, digits, and underscores (</em>). It cannot be set to sys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_info</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
