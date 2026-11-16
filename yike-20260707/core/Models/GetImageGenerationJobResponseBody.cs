// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetImageGenerationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The image generation job.</para>
        /// </summary>
        [NameInMap("ImageGenerationJob")]
        [Validation(Required=false)]
        public GetImageGenerationJobResponseBodyImageGenerationJob ImageGenerationJob { get; set; }
        public class GetImageGenerationJobResponseBodyImageGenerationJob : TeaModel {
            /// <summary>
            /// <para>The aspect ratio of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            /// <summary>
            /// <para>The error message. The value is a string. This field is returned when the job status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Input file not found.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The job input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Prompt&quot;:&quot;Image 1 is on the basketball court, performing a slam dunk using Image 2&quot;}</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag_68ca759b4903b255*******</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job feature configurations. No configuration is required at this time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <para>The job type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text_to_image</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wan2.7-image</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of generated images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public string N { get; set; }

            /// <summary>
            /// <para>The generation result. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description>Medias: the list of media information (Media objects). A Media object contains the following fields:<list type="bullet">
            /// <item><description>MediaId: String. The media asset ID.</description></item>
            /// <item><description>OutputUrl: String. The media URL, including the authentication string.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Medias&quot;:[{&quot;MediaId&quot;:&quot;<em><b>e3700761971f19c32e7e7d5496</b></em>&quot;,&quot;OutputUrl&quot;:&quot;https://<b>bucket</b>.oss-ap-southeast-1.aliyuncs.com/xxx.prd&quot;}]}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The resolution of the generated video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1K</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The scene type. Currently, only <c>general</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The job is created.</description></item>
            /// <item><description>Queuing: The job is queuing.</description></item>
            /// <item><description>Executing: The job is executing.</description></item>
            /// <item><description>Finished: The job succeeded.</description></item>
            /// <item><description>Failed: The job failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
