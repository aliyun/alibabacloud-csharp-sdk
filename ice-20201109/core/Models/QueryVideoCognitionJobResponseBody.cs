// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryVideoCognitionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b></description></item>
        /// <item><description><b>Fail</b></description></item>
        /// <item><description><b>Processing</b></description></item>
        /// <item><description><b>Submitted</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of analysis result objects.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public QueryVideoCognitionJobResponseBodyResults Results { get; set; }
        public class QueryVideoCognitionJobResponseBodyResults : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<QueryVideoCognitionJobResponseBodyResultsResult> Result { get; set; }
            public class QueryVideoCognitionJobResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// <para>A JSON string containing the detailed analysis data. The structure of this data depends on the Type field. For details, see the Result parameters section below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;example-title-****&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <para>The type of analysis result. Valid values:</para>
                /// <ol>
                /// <item><description>TextLabel: Tags from text content.</description></item>
                /// <item><description>VideoLabel: Tags from video content.</description></item>
                /// <item><description>ASR: Raw speech recognition results. Not returned by default.</description></item>
                /// <item><description>OCR: Raw text recognition results. Not returned by default.</description></item>
                /// <item><description>NLP: Natural Language Processing results. Not returned by default.</description></item>
                /// <item><description>Process: URL to the raw algorithm output. Not returned by default.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>ASR</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;123432412831&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
