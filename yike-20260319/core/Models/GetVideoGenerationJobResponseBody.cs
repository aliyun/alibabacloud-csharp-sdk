// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetVideoGenerationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The video generation task.</para>
        /// </summary>
        [NameInMap("VideoGenerationJob")]
        [Validation(Required=false)]
        public GetVideoGenerationJobResponseBodyVideoGenerationJob VideoGenerationJob { get; set; }
        public class GetVideoGenerationJobResponseBodyVideoGenerationJob : TeaModel {
            /// <summary>
            /// <para>The aspect ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            /// <summary>
            /// <para>The video duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is returned when the task is in the Failed state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Input file not found.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The task input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Prompt&quot;:&quot;图1在篮球场上，用图2来了个灌篮&quot;,&quot;Medias&quot;:[{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;<a href="https://xxx/xxx.jpg%22%7D,%7B%22Type%22:%22image%22,%22Url%22:%22https://xxx/xxx.jpg%22%7D%5D%7D">https://xxx/xxx.jpg&quot;},{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;https://xxx/xxx.jpg&quot;}]}</a></para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fdc7f121056249c2b64e04bba27bcc8c</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task feature configuration. This parameter does not need to be set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("JobParameters")]
            [Validation(Required=false)]
            public string JobParameters { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>first_last_frame</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>happyhorse-1.1</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of generated videos.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public int? N { get; set; }

            /// <summary>
            /// <para>The output result in JsonString format. The following fields are included:</para>
            /// <para>Medias: a list of media information (Media objects). The Media object contains the following fields:
            /// MediaId: String. The media asset ID.
            /// OutputUrl: String. The media URL (with the authentication string).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Medias\&quot;:[{\&quot;MediaId\&quot;:\&quot;<em><b><b>470732171f1bfcaf7f6d44</b></b></em>\&quot;,\&quot;OutputUrl\&quot;:\&quot;<a href="https://xxxxxxx/.../xxxxx.mp4?Expires=xxxx&OSSAccessKeyId=xxx&Signature=xxxx%5C%5C%22%7D%5D%7D">https://xxxxxxx/.../xxxxx.mp4?Expires=xxxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxxx\\&quot;}]}</a></para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720P</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The scene type. Currently, only general is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The task is created.</description></item>
            /// <item><description>Queuing: The task is queuing.</description></item>
            /// <item><description>Executing: The task is being executed.</description></item>
            /// <item><description>Finished: The task is completed.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
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

    }

}
