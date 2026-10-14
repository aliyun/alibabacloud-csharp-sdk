// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetImageIncomeTaxDetectionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The business error code.</b> The value &quot;OK&quot; is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para><b>The HTTP status code.</b> The value 200 is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para><b>The list of detected abnormal items.</b> Returned only when <c>Status</c> is <c>succeeded</c>. An empty array indicates that no abnormal items are detected.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetImageIncomeTaxDetectionTaskResultResponseBodyItems> Items { get; set; }
        public class GetImageIncomeTaxDetectionTaskResultResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The text description of the abnormal item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month sequence anomaly: 2022-05 -&gt; 2022-11 (should be in descending or equal order)</para>
            /// </summary>
            [NameInMap("AbnormalItem")]
            [Validation(Required=false)]
            public string AbnormalItem { get; set; }

            /// <summary>
            /// <para>The bounding box position of the abnormal item in the image. May be an empty array for image-wide abnormalities.</para>
            /// </summary>
            [NameInMap("Coordinates")]
            [Validation(Required=false)]
            public List<GetImageIncomeTaxDetectionTaskResultResponseBodyItemsCoordinates> Coordinates { get; set; }
            public class GetImageIncomeTaxDetectionTaskResultResponseBodyItemsCoordinates : TeaModel {
                /// <summary>
                /// <para>The X-coordinate of the upper-left corner (pixels).</para>
                /// 
                /// <b>Example:</b>
                /// <para>928</para>
                /// </summary>
                [NameInMap("X1")]
                [Validation(Required=false)]
                public int? X1 { get; set; }

                /// <summary>
                /// <para>The X-coordinate of the lower-right corner of the bounding box (pixels).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1147</para>
                /// </summary>
                [NameInMap("X2")]
                [Validation(Required=false)]
                public int? X2 { get; set; }

                /// <summary>
                /// <para>The Y-coordinate of the upper-left corner (pixels).</para>
                /// 
                /// <b>Example:</b>
                /// <para>792</para>
                /// </summary>
                [NameInMap("Y1")]
                [Validation(Required=false)]
                public int? Y1 { get; set; }

                /// <summary>
                /// <para>The Y-coordinate of the lower-right corner of the bounding box (pixels).</para>
                /// 
                /// <b>Example:</b>
                /// <para>847</para>
                /// </summary>
                [NameInMap("Y2")]
                [Validation(Required=false)]
                public int? Y2 { get; set; }

            }

            /// <summary>
            /// <para>The detection stage identifier for the abnormality.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stage2</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

        }

        /// <summary>
        /// <para>The failure reason when the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>poll timeout: no result within 30m0s</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The raw downstream detection result (extend.result string) for troubleshooting and passing through new fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;items&quot;: []}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para><b>The task status.</b> Valid values: <c>running</c> (in progress), <c>succeeded</c> (completed), <c>failed</c> (failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para><b>The task ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
