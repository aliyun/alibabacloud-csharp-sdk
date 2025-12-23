// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifySecondRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5E2F73C-8241-81F8-3A62-65478C5A3111</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the fine sort expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifySecondRankResponseBodyResult Result { get; set; }
        public class ModifySecondRankResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the expression is the default one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The time when the expression was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The description of the expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;11&quot;</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expression ID. This parameter is displayed only in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>890473</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the expression is the default one. This parameter is displayed only in the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: the expression is the default one.</description></item>
            /// <item><description>false: the expression is not the default one.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the expression is a system expression. This parameter is displayed only in the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The expression is a system expression.</description></item>
            /// <item><description>false:The expression is not a system expression</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isSys")]
            [Validation(Required=false)]
            public string IsSys { get; set; }

            /// <summary>
            /// <para>The content of the fine sort expression. You can define an expression that consists of fields, feature functions, and mathematical functions to implement complex sort logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cate_id &gt; 0 and cate_id &lt; 1000</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>The expression name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsh_second_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the expression was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
