// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class EvaluateVideoQualityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EvaluateVideoQualityResponseBodyData Data { get; set; }
        public class EvaluateVideoQualityResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/eas-video-quality-assessment/2023-01-13-10/31%3A08-cVeN9ZQlzIPfGqsa.json?Expires=1673578869&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=AiSsOsZ7rYfhf9w3Mxn%2Fq4GKKy">http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/eas-video-quality-assessment/2023-01-13-10/31%3A08-cVeN9ZQlzIPfGqsa.json?Expires=1673578869&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=AiSsOsZ7rYfhf9w3Mxn%2Fq4GKKy</a>****</para>
            /// </summary>
            [NameInMap("JsonUrl")]
            [Validation(Required=false)]
            public string JsonUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/eas-video-quality-assessment/2023-01-13-10/31%3A08-cVeN9ZQlzIPfGqsa.pdf?Expires=1673578869&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=xULlZzVuhoYWAXRbp9A4EzzZcS">http://vibktprfx-prod-prod-damo-eas-cn-shanghai.oss-cn-shanghai.aliyuncs.com/eas-video-quality-assessment/2023-01-13-10/31%3A08-cVeN9ZQlzIPfGqsa.pdf?Expires=1673578869&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=xULlZzVuhoYWAXRbp9A4EzzZcS</a>****</para>
            /// </summary>
            [NameInMap("PdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            [NameInMap("VideoQualityInfo")]
            [Validation(Required=false)]
            public EvaluateVideoQualityResponseBodyDataVideoQualityInfo VideoQualityInfo { get; set; }
            public class EvaluateVideoQualityResponseBodyDataVideoQualityInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.15</para>
                /// </summary>
                [NameInMap("Blurriness")]
                [Validation(Required=false)]
                public float? Blurriness { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.55</para>
                /// </summary>
                [NameInMap("ColorContrast")]
                [Validation(Required=false)]
                public float? ColorContrast { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.17</para>
                /// </summary>
                [NameInMap("ColorSaturation")]
                [Validation(Required=false)]
                public float? ColorSaturation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.48</para>
                /// </summary>
                [NameInMap("Colorfulness")]
                [Validation(Required=false)]
                public float? Colorfulness { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("CompressiveStrength")]
                [Validation(Required=false)]
                public float? CompressiveStrength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.51</para>
                /// </summary>
                [NameInMap("Luminance")]
                [Validation(Required=false)]
                public float? Luminance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7048</para>
                /// </summary>
                [NameInMap("MosScore")]
                [Validation(Required=false)]
                public float? MosScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("NoiseIntensity")]
                [Validation(Required=false)]
                public float? NoiseIntensity { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1d33e538-c949-4fcd-83f6-4d57e4b31527</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
