// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSmarttagJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the video content can contain Chinese characters, English letters, digits, and hyphens (-). It cannot start with a special character and must not exceed 1 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example content ****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// </summary>
        [NameInMap("ContentAddr")]
        [Validation(Required=false)]
        public string ContentAddr { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The input file for the job.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestInput Input { get; set; }
        public class SubmitSmarttagJobRequestInput : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>If you set the <c>Type</c> parameter to <c>OSS</c>, specify the OSS URL of the media file. Example: <c>OSS://test-bucket/video/202208/test.mp4</c>.</para>
            /// </description></item>
            /// <item><description><para>If you set the <c>Type</c> parameter to <c>Media</c>, specify the media ID. Example: <c>c5c62d8f0361337cab312dce8e77dc6d</c>.</para>
            /// </description></item>
            /// <item><description><para>If you set the <c>Type</c> parameter to <c>URL</c>, specify the HTTP or HTTPS URL of the media file. Example: <c>https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c5c62d8f0361337cab312dce8e77dc6d</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OSS</para>
            /// </description></item>
            /// <item><description><para>Media</para>
            /// </description></item>
            /// <item><description><para>URL</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The callback URL. Only HTTP and HTTPS URLs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/endpoint/aliyun/ai?id=76401125000">https://example.com/endpoint/aliyun/ai?id=76401125000</a>***</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>Additional request parameters, specified as a JSON string. For example: <c>{&quot;needAsrData&quot;:true, &quot;needOcrData&quot;:false}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>needAsrData</c>: Specifies whether to include the raw Automatic Speech Recognition (ASR) results in the analysis output. The default is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para><c>needOcrData</c>: Specifies whether to include the raw Optical Character Recognition (OCR) results in the analysis output. The default is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para><c>needMetaData</c>: Specifies whether to include metadata in the analysis output. The default is <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para><c>nlpParams</c>: A JSON object that specifies the input parameters for the Natural Language Processing (NLP) operator. If left empty, the operator is not used. For details, see the <c>nlpParams</c> table below.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;needAsrData&quot;:true, &quot;needOcrData&quot;:false, &quot;nlpParams&quot;:{&quot;sourceLanguage&quot;:&quot;cn&quot;}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The scheduling configurations.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSmarttagJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the pipeline. Pipelines separate business workloads and bind message notifications.</para>
            /// <para>If you do not specify this parameter, the default pipeline is used. The default pipeline has a concurrency of 2. To increase the concurrency, submit a ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acdbfe4323bcfdae</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. This feature is not yet implemented. You can leave this parameter empty or specify any value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

        }

        /// <summary>
        /// <para>Dynamic parameters for the job, which temporarily override or supplement the base template specified by <c>TemplateId</c>. The service merges the dynamic and template parameters to generate the final configuration for the current job and validates it before execution.</para>
        /// <list type="bullet">
        /// <item><description>Merge rules:</description></item>
        /// </list>
        /// <ol>
        /// <item><description><para>Values in the request override corresponding values in the template.</para>
        /// </description></item>
        /// <item><description><para>Fields in the request that do not exist in the template are added to the configuration.</para>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Currently supported dynamic fields:</description></item>
        /// </list>
        /// <ol>
        /// <item><description><c>FaceCategoryIds</c>: A list of face library IDs for recognition, separated by commas (,). You can include both system and custom library IDs.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Note: These dynamic parameters affect only the current job and do not modify the template itself.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FaceCategoryIds&quot;:&quot;custom_face_lib1&quot;}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The ID of the template that specifies the analysis algorithms to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The video title can contain Chinese characters, English letters, digits, and hyphens (-). It cannot start with a special character and must not exceed 256 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Custom data to include in the callback. If you use Message Service (MNS) for callbacks, this data is included in the message. The maximum length is 1 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“a”:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
