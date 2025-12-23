// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeInterventionDictionaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7CCF454-472A-030E-F254-604520B028AA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the intervention dictionary.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeInterventionDictionaryResponseBodyResult Result { get; set; }
        public class DescribeInterventionDictionaryResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The custom analyzer.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// <para>The time when the the intervention dictionary was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536233287</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The name of the the intervention dictionary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Type</para>
            /// <list type="bullet">
            /// <item><description>stopword: an intervention dictionary for stop word filtering.</description></item>
            /// <item><description>synonym: an intervention dictionary for synonym configuration.</description></item>
            /// <item><description>correction: an intervention dictionary for spelling correction.</description></item>
            /// <item><description>category_prediction: an intervention dictionary for category prediction.</description></item>
            /// <item><description>ner: an intervention dictionary for named entity recognition.</description></item>
            /// <item><description>term_weighting: an intervention dictionary for term weight analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>category_prediction</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the the intervention dictionary was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536233287</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
