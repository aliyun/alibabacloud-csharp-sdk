// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionProResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detection results of the Pro edition.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MerchandisePlacementDetectionProResponseBodyData Data { get; set; }
        public class MerchandisePlacementDetectionProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of valid bounding boxes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BoxCount")]
            [Validation(Required=false)]
            public int? BoxCount { get; set; }

            /// <summary>
            /// <para>The list of detection details for each bounding box.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<MerchandisePlacementDetectionProResponseBodyDataData> Data { get; set; }
            public class MerchandisePlacementDetectionProResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The normalized bounding box coordinates in the [x1,y1,x2,y2] format. Valid values: 0 to 1000.</para>
                /// </summary>
                [NameInMap("Bbox2d")]
                [Validation(Required=false)]
                public List<int?> Bbox2d { get; set; }

                /// <summary>
                /// <para>The recognized product name. If the name cannot be determined, the value is unknown.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unknown</para>
                /// </summary>
                [NameInMap("DetectedSkuName")]
                [Validation(Required=false)]
                public string DetectedSkuName { get; set; }

                /// <summary>
                /// <para>The index of the bounding box, starting from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Idx")]
                [Validation(Required=false)]
                public int? Idx { get; set; }

            }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The return message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
