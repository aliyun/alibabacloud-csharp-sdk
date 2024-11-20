// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSmarttagJobRequest : TeaModel {
        /// <summary>
        /// <para>The video description. The description can contain letters, digits, and hyphens (-) and cannot start with a special character. The description can be up to 1 KB in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example content ****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://123.com/testVideo.mp4">http://123.com/testVideo.mp4</a></para>
        /// </summary>
        [NameInMap("ContentAddr")]
        [Validation(Required=false)]
        public string ContentAddr { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/zip</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The job input.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSmarttagJobRequestInput Input { get; set; }
        public class SubmitSmarttagJobRequestInput : TeaModel {
            /// <summary>
            /// <para>If Type is set to OSS, specify an OSS path. Example: OSS://test-bucket/video/202208/test.mp4.</para>
            /// <para>If Type is set to Media, specify a media asset ID. Example: c5c62d8f0361337cab312dce8e77dc6d.</para>
            /// <para>If Type is set to URL, specify an HTTP URL. Example: <a href="https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4">https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5c62d8f0361337cab312dce8e77dc6d</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The media type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS</description></item>
            /// <item><description>Media</description></item>
            /// <item><description>URL</description></item>
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
        /// <para>The URL for receiving callbacks. Set the value to an HTTP URL or an HTTPS URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/endpoint/aliyun/ai?id=76401125000">https://example.com/endpoint/aliyun/ai?id=76401125000</a>***</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The additional request parameters. The value is a JSON string. Example: {&quot;needAsrData&quot;:true, &quot;needOcrData&quot;:false}. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>needAsrData: specifies whether to query the automatic speech recognition (ASR) data. The value is of the BOOLEAN type. Default value: false. Valid values: true and false.</description></item>
        /// <item><description>needOcrData: specifies whether to query the optical character recognition (OCR) data. The value is of the BOOLEAN type. Default value: false. Valid values: true and false.</description></item>
        /// <item><description>needMetaData: specifies whether to query the metadata. The value is of the BOOLEAN type. Default value: false. Valid values: true and false.</description></item>
        /// <item><description>nlpParams: the input parameters of the natural language processing (NLP) operator. The value is a JSON object. This parameter is empty by default, which indicates that the NLP operator is not used. For more information, see the &quot;nlpParams&quot; section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;needAsrData&quot;:true, &quot;needOcrData&quot;:false}</para>
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
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which you want to submit the smart tagging job. The MPS queue is bound to an SMQ queue. This parameter specifies the default MPS queue. By default, an MPS queue can process a maximum of two concurrent smart tagging jobs. To increase the limit, submit a ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acdbfe4323bcfdae</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The job priority. This parameter is not implemented. You can leave this parameter empty or enter a random value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

        }

        /// <summary>
        /// <para>The ID of the template that specifies the analysis algorithms. For more information about template operations, see <a href="https://help.aliyun.com/document_detail/445702.html">Configure templates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The video title. The title can contain letters, digits, and hyphens (-) and cannot start with a special character. The title can be up to 256 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The data to be passed through Simple Message Queue (SMQ, formerly MNS) during callbacks. The data can be up to 1 KB in length. For more information about how to specify an SMQ queue for receiving callbacks, see UpdatePipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“a”:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
