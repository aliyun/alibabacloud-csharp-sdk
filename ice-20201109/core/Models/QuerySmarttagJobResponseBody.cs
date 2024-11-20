// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySmarttagJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: The job was successful.</description></item>
        /// <item><description><b>Fail</b>: The job failed.</description></item>
        /// <item><description><b>Processing</b>: The job is in progress.</description></item>
        /// <item><description><b>Submitted</b>: The job is submitted and waiting to be processed.</description></item>
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
        /// <para>The analysis results of the smart tagging job. The value is an array.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public QuerySmarttagJobResponseBodyResults Results { get; set; }
        public class QuerySmarttagJobResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QuerySmarttagJobResponseBodyResultsResult> Result { get; set; }
            public class QuerySmarttagJobResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// <para>The details of the analysis result. The value is a JSON string. For more information about the parameters of different result types, see the &quot;Parameters of different result types&quot; section of this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;example-title-****&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <para>The type of the analysis result.</para>
                /// <list type="bullet">
                /// <item><description>The type of the analysis result based on Smart tagging V1.0. Valid values:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>TextLabel: the text tag.</description></item>
                /// <item><description>VideoLabel: the video tag.</description></item>
                /// <item><description>ASR: the original result of automatic speech recognition (ASR). By default, this type of result is not returned.</description></item>
                /// <item><description>OCR: the original result of optical character recognition (OCR). By default, this type of result is not returned.</description></item>
                /// <item><description>NLP: the natural language processing (NLP)-based result. By default, this type of result is not returned.</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>The type of the analysis result based on Smart tagging V2.0. Valid values:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>CPVLabel</description></item>
                /// <item><description>Meta: the information about the video file, such as the title of the video. By default, this type of information is not returned.</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>The type of the analysis result based on Smart tagging V2.0-custom. Valid values:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>CPVLabel</description></item>
                /// <item><description>Meta: the information about the video file, such as the title of the video. By default, this type of information is not returned.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>Meta</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The content of callback messages that are sent to Simple Message Queue (SMQ) when the information of the smart tagging job changes. For more information about the parameters contained in the callback message, see the &quot;Callback parameters&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;123432412831&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
