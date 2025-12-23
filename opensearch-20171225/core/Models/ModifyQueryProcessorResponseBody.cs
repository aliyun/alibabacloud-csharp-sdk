// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyQueryProcessorResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the query analysis rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyQueryProcessorResponseBodyResult Result { get; set; }
        public class ModifyQueryProcessorResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the query analysis rule is a default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The type of the industry to which the query analysis rule is applied. Valid values:</para>
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
            /// <para>The indexes to which the query analysis rule is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;default&quot;]</para>
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// <para>The name of the query analysis rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>synonym</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The analysis rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Processors { get; set; }

            /// <summary>
            /// <para>The time when the rule was updated.</para>
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
