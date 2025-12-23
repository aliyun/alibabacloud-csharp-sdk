// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeQueryProcessorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the query analysis rule.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeQueryProcessorResponseBodyResult Result { get; set; }
        public class DescribeQueryProcessorResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the query analysis rule is the default one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The time when the query analysis rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587398402</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The type of the industry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GENERAL</description></item>
            /// <item><description>ECOMMERCE</description></item>
            /// <item><description>IT_CONTENT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The indexes to which the query analysis rule applies.</para>
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// <para>The name of the query analysis rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The features that are used in the query analysis rule.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Processors { get; set; }

            /// <summary>
            /// <para>The time when the query analysis rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587398402</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
