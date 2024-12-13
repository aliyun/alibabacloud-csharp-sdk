// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The material parameters of the template, in the JSON format. If TemplateId is specified, ClipsParam must also be specified. For more information, see <a href="https://help.aliyun.com/document_detail/445399.html">Create and use a regular template</a> and <a href="https://help.aliyun.com/document_detail/445389.html">Create and use advanced templates</a>.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The parameters for editing and production. For more information, see <a href="https://help.aliyun.com/document_detail/357745.html">EditingProduceConfig</a>.</para>
        /// <remarks>
        /// <para> If no thumbnail is specified in EditingProduceConfig, the first frame of the video is used as the thumbnail.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>AutoRegisterInputVodMedia: specifies whether to automatically register the ApsaraVideo VOD media assets in your timeline with IMS. Default value: true.</description></item>
        /// <item><description>OutputWebmTransparentChannel: specifies whether the output video contains alpha channels. Default value: false.</description></item>
        /// <item><description>CoverConfig: the custom thumbnail parameters.</description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;AutoRegisterInputVodMedia&quot;: &quot;true&quot;,
        ///       &quot;OutputWebmTransparentChannel&quot;: &quot;true&quot;
        /// }</para>
        /// </summary>
        [NameInMap("EditingProduceConfig")]
        [Validation(Required=false)]
        public string EditingProduceConfig { get; set; }

        /// <summary>
        /// <para>The metadata of the produced video, in the JSON format. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/357745.html">MediaMetadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Title&quot;:&quot;test-title&quot;,
        ///       &quot;Tags&quot;:&quot;test-tags1,tags2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        /// <summary>
        /// <para>The configurations of the output file, in the JSON format. You can specify an OSS URL or a storage location in a storage bucket of ApsaraVideo VOD.</para>
        /// <para>To store the output file in OSS, you must specify MediaURL. To store the output file in ApsaraVideo VOD, you must specify StorageLocation and FileName.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/357745.html">OutputMediaConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4%22%7D">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The type of the output file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss-object: OSS object in an OSS bucket.</description></item>
        /// <item><description>vod-media: media asset in ApsaraVideo VOD.</description></item>
        /// <item><description>S3: output file based on the Amazon Simple Storage Service (S3) protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <para>The ID of the editing project.</para>
        /// <remarks>
        /// <para>: You must specify one of ProgectId, Timeline, and TempalteId and leave the other two parameters empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxfb2101cb318xxxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The metadata of the editing project, in the JSON format. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/357745.html">ProjectMetadata</a>.</para>
        /// </summary>
        [NameInMap("ProjectMetadata")]
        [Validation(Required=false)]
        public string ProjectMetadata { get; set; }

        /// <summary>
        /// <para>The source of the editing and production request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OpenAPI</description></item>
        /// <item><description>AliyunConsole</description></item>
        /// <item><description>WebSDK</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPENAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The template ID. The template is used to build a timeline with ease.</para>
        /// <remarks>
        /// <para>: You must specify one of ProgectId, Timeline, and TempalteId and leave the other two parameters empty. If TemplateId is specified, ClipsParam must also be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://xx.com/xx%22,%22RegisterMediaNotifyAddress%22:%22https://xxx.com/xx%22%7D">https://xx.com/xx&quot;,&quot;RegisterMediaNotifyAddress&quot;:&quot;https://xxx.com/xx&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
