// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Result of the face comparison.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFacesResponseBodyData Data { get; set; }
        public class CompareFacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Confidence thresholds for face comparison. The returned content is a JSON Object, with the specific structure being <c>&quot;key&quot;:&quot;value&quot;</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>key</c> represents the false acceptance rate, which is the probability of misidentifying someone else as the specified person.</description></item>
            /// <item><description><c>value</c> is the corresponding threshold.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Regarding the confidence thresholds (confidenceThresholds) in the example:</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><c>&quot;0.0001&quot;: &quot;90.07&quot;</c> indicates that the threshold is 90.07 when the false acceptance rate is 0.01%.</description></item>
            /// <item><description><c>&quot;0.001&quot;: &quot;80.01&quot;</c> indicates that the threshold is 80.01 when the false acceptance rate is 0.1%.</description></item>
            /// <item><description><c>&quot;0.01&quot;: &quot;70.02&quot;</c> indicates that the threshold is 70.02 when the false acceptance rate is 1%.</description></item>
            /// </list>
            /// <para>Confidence thresholds are dynamically provided based on different images and algorithms, so do not persist these thresholds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;0.0001&quot;:&quot;90.07&quot;,&quot;0.001&quot;:&quot;80.01&quot;,&quot;0.01&quot;:&quot;70.02&quot;}</para>
            /// </summary>
            [NameInMap("ConfidenceThresholds")]
            [Validation(Required=false)]
            public string ConfidenceThresholds { get; set; }

            /// <summary>
            /// <para>The degree of similarity between the faces in the two images. The value range is [0, 100], with higher values indicating greater similarity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98.7913</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public float? SimilarityScore { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error.InternalError</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
