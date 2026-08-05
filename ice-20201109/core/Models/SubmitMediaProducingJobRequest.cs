// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The material parameters corresponding to the template, in JSON format. When TemplateId is not empty, ClipsParam cannot be empty. For the specific format, see <a href="https://help.aliyun.com/document_detail/445399.html">Create and use a standard template</a> and <a href="https://help.aliyun.com/document_detail/445389.html">Create and use an advanced template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>See the template user guide.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The editing and compositing configuration. For more information, see <a href="~~357745#section-8a4-pb2-hkv~~">EditingProduceConfig parameter details</a>.</para>
        /// <remarks>
        /// <para>If no cover image is configured in EditingProduceConfig, the first frame of the video is used as the cover by default.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>AutoRegisterInputVodMedia: specifies whether to automatically register VOD media assets in your timeline to IMS. Default value: true.</para>
        /// </description></item>
        /// <item><description><para>OutputWebmTransparentChannel: specifies whether to output video with a transparent channel. Default value: false.</para>
        /// </description></item>
        /// <item><description><para>CoverConfig: custom cover image parameters.</para>
        /// </description></item>
        /// <item><description><para>......</para>
        /// </description></item>
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
        /// <para>The metadata of the produced video, in JSON format. For the specific structure definition, see <a href="~~357745#97ff26d0e3c28~~">MediaMetadata</a>.</para>
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
        /// <para>The target configuration of the output media, in JSON format. You can set the OSS URL or the storage location in a VOD bucket for the output media.</para>
        /// <list type="bullet">
        /// <item><description>When outputting to OSS, the MediaURL of the output target is required.</description></item>
        /// <item><description>When outputting to VOD, the StorageLocation and FileName parameters are required.</description></item>
        /// </list>
        /// <para><a href="~~357745#title-4j6-ve7-g31~~">OutputMediaConfig parameter examples</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4%22%7D">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The target type of the output media. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>oss-object: an OSS object in your Alibaba Cloud OSS bucket.</para>
        /// </description></item>
        /// <item><description><para>vod-media: a media asset in ApsaraVideo VOD.</para>
        /// </description></item>
        /// <item><description><para>S3: output using the S3 protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <para>The editing project ID. You can call the <a href="https://help.aliyun.com/document_detail/441137.html">CreateEditingProject</a> operation to create an editing project and obtain the ProjectId to submit an editing task.</para>
        /// <remarks>
        /// <para>Notice: You must specify one of the following three parameters: ProjectId, Timeline, or TemplateId. Leave the other two parameters empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxfb2101cb318xxxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The metadata of the editing project, in JSON format. For the specific structure definition, see <a href="~~357745#title-yvp-81k-wff~~">ProjectMetadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Description&quot;:&quot;Video editing description&quot;,&quot;Title&quot;:&quot;Editing title test&quot;}</para>
        /// </summary>
        [NameInMap("ProjectMetadata")]
        [Validation(Required=false)]
        public string ProjectMetadata { get; set; }

        /// <summary>
        /// <para>The source of the editing and compositing request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OpenAPI: a direct API request.</para>
        /// </description></item>
        /// <item><description><para>AliyunConsole: a request from the Alibaba Cloud Management Console.</para>
        /// </description></item>
        /// <item><description><para>WebSDK: a request from a frontend page integrated with WebSDK.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPENAPI</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The template ID, which is used to quickly build a timeline with minimal effort. Video clip editing based on both standard templates and advanced templates is supported.</para>
        /// <list type="bullet">
        /// <item><description><para>When you commit a media producing job by using a template ID, you must provide the ClipsParam parameter to flexibly adjust or replace materials in the template.</para>
        /// </description></item>
        /// <item><description><para>You can invoke <a href="https://help.aliyun.com/document_detail/441164.html">GetTemplate</a> to obtain template information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: You must specify one of the following three parameters: ProjectId, Timeline, or TemplateId. Leave the other two parameters empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The timeline of the cloud editing task. When you need to arrange materials and design effects based on your video creative ideas, you can manually construct the Timeline parameter.</para>
        /// <list type="bullet">
        /// <item><description>A timeline mainly contains three types of objects: tracks, materials, and effects. For more information, see <a href="https://help.aliyun.com/document_detail/198823.html">Timeline configuration</a>.</description></item>
        /// <item><description>For more timeline configuration examples, see <a href="https://help.aliyun.com/document_detail/2766669.html">Best Practices</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: You must specify one of the following three parameters: ProjectId, Timeline, or TemplateId. Leave the other two parameters empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>Custom settings, in JSON format, with a maximum length of 512 bytes. Supports <a href="https://help.aliyun.com/document_detail/451631.html">task completion callback configuration</a>. The fields include:</para>
        /// <list type="bullet">
        /// <item><description>NotifyAddress: the callback URL for task completion.</description></item>
        /// <item><description>RegisterMediaNotifyAddress: the callback URL for media asset analysis completion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="https://xx.com/xx%22,%22RegisterMediaNotifyAddress%22:%22https://xxx.com/xx%22%7D">https://xx.com/xx&quot;,&quot;RegisterMediaNotifyAddress&quot;:&quot;https://xxx.com/xx&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
