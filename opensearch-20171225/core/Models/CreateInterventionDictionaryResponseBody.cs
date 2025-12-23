// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateInterventionDictionaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80326EFE-485F-46E7-B291-5A1DD08D2198</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateInterventionDictionaryResponseBodyResult Result { get; set; }
        public class CreateInterventionDictionaryResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The custom analyzer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dianshang</para>
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// <para>The time when the test scenario was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1591086323</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The name of the test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the intervention dictionary. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stopword: an intervention dictionary for stop word filtering</description></item>
            /// <item><description>synonym: an intervention dictionary for synonym configuration</description></item>
            /// <item><description>correction: an intervention dictionary for spelling correction</description></item>
            /// <item><description>category_prediction: an intervention dictionary for category prediction</description></item>
            /// <item><description>ner: an intervention dictionary for named entity recognition (NER)</description></item>
            /// <item><description>term_weighting: an intervention dictionary for term weight analysis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ner</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the intervention dictionary was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1591086323</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
