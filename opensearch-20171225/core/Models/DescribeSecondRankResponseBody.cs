// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSecondRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the fine sort expression.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSecondRankResponseBodyResult Result { get; set; }
        public class DescribeSecondRankResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Specifies whether to set the fine sort expression as the default sort expression.</para>
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
            /// <para>1587052801</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the expression. This parameter appears only in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89047</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the expression is the default one. This parameter appears only in the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the expression is a system expression. This parameter appears only in the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>random()+now()</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tests</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the expression was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587052801</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
