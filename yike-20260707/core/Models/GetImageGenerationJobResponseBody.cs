// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetImageGenerationJobResponseBody : TeaModel {
        [NameInMap("ImageGenerationJob")]
        [Validation(Required=false)]
        public GetImageGenerationJobResponseBodyImageGenerationJob ImageGenerationJob { get; set; }
        public class GetImageGenerationJobResponseBodyImageGenerationJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Input file not found.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Prompt&quot;:&quot;图1在篮球场上，用图2来了个灌篮&quot;}</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fdc7f121056249c2b64e04bba27bcc8c</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text_to_image</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wan2.7-image</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public string N { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Medias&quot;:[{&quot;MediaId&quot;:&quot;<em><b>e3700761971f19c32e7e7d5496</b></em>&quot;,&quot;OutputUrl&quot;:&quot;https://<b>bucket</b>.oss-ap-southeast-1.aliyuncs.com/xxx.prd&quot;}]}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1K</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
