// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateQueryProcessorResponseBody : TeaModel {
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
        /// <para>The information about the query analysis rule.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateQueryProcessorResponseBodyResult Result { get; set; }
        public class CreateQueryProcessorResponseBodyResult : TeaModel {
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
            /// <para>The type of the industry to which the query analysis rule was applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GENERAL: general.</description></item>
            /// <item><description>ECOMMERCE: e-commerce.</description></item>
            /// <item><description>IT_CONTENT: IT content.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The indexes to which the query analysis rule was applied.</para>
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// <para>The name of the query analysis rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query_filter</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The features that are used in the query analysis rule.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/170014.html">QueryProcessor</a>.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Processors { get; set; }

            /// <summary>
            /// <para>The time when the query analysis rule was last modified.</para>
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
