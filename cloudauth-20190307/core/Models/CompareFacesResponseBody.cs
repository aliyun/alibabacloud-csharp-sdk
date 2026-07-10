// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The face comparison result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFacesResponseBodyData Data { get; set; }
        public class CompareFacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The confidence thresholds for face comparison. The returned content is a JSON object with the structure <c>&quot;key&quot;:&quot;value&quot;</c>.</para>
            /// <list type="bullet">
            /// <item><description><c>key</c> is the false acceptance rate (FAR), which is the probability of incorrectly identifying another person as the specified person.</description></item>
            /// <item><description><c>value</c> is the corresponding threshold.</description></item>
            /// </list>
            /// <remarks>
            /// <para>About the confidence thresholds (confidenceThresholds) in the example:</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><c>&quot;0.0001&quot;: &quot;90.07&quot;</c> indicates that the corresponding threshold is 90.07 when the FAR is 0.01%.</description></item>
            /// <item><description><c>&quot;0.001&quot;: &quot;80.01&quot;</c> indicates that the corresponding threshold is 80.01 when the FAR is 0.1%.</description></item>
            /// <item><description><c>&quot;0.01&quot;: &quot;70.02&quot;</c> indicates that the corresponding threshold is 70.02 when the FAR is 1%.</description></item>
            /// </list>
            /// <para>The confidence thresholds are dynamically generated based on different images and algorithms. Do not persist the confidence thresholds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;0.0001&quot;:&quot;90.07&quot;,&quot;0.001&quot;:&quot;80.01&quot;,&quot;0.01&quot;:&quot;70.02&quot;}</para>
            /// </summary>
            [NameInMap("ConfidenceThresholds")]
            [Validation(Required=false)]
            public string ConfidenceThresholds { get; set; }

            /// <summary>
            /// <para>The similarity score between the faces in the two images. Valid values: [0, 100]. A higher value indicates a greater similarity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98.7913</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public float? SimilarityScore { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error.InternalError</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
