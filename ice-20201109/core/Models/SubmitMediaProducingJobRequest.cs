// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures request idempotence. This token must be a unique value of up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The clip parameters that correspond to the template, in JSON format. If <c>TemplateId</c> is specified, this parameter is required. For details about the format, see <a href="https://help.aliyun.com/document_detail/445399.html">Create and use basic templates</a> and <a href="https://help.aliyun.com/document_detail/445389.html">Create and use advanced templates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>See the template user guide.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The parameters for the media producing job. For configuration details, see <a href="~~357745#section-8a4-pb2-hkv~~">EditingProduceConfig parameter details</a>.</para>
        /// <remarks>
        /// <para>If a cover is not configured in <c>EditingProduceConfig</c>, the first frame of the video is used as the default cover.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>AutoRegisterInputVodMedia</c>: Specifies whether to automatically register the VOD media assets in your timeline to IMS. Default value: true.</para>
        /// </description></item>
        /// <item><description><para><c>OutputWebmTransparentChannel</c>: Specifies whether to output a video with a transparent channel. Default value: false.</para>
        /// </description></item>
        /// <item><description><para><c>CoverConfig</c>: The parameters for a custom cover.</para>
        /// </description></item>
        /// <item><description><para>...</para>
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
        /// <para>The metadata of the output video, in JSON format. For details about the structure, see <a href="~~357745#97ff26d0e3c28~~">MediaMetadata</a>.</para>
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
        /// <para>The configuration for the output media target, in JSON format. You can set the URL for the output media in OSS or the storage location in a VOD bucket.</para>
        /// <list type="bullet">
        /// <item><description><para>When outputting to OSS, the <c>MediaURL</c> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>When outputting to VOD, both the <c>StorageLocation</c> and <c>FileName</c> parameters are required.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="~~357745#title-4j6-ve7-g31~~">OutputMediaConfig parameter examples</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4%22%7D">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The target type for the output media. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>oss-object</c>: An object in your Alibaba Cloud OSS bucket.</para>
        /// </description></item>
        /// <item><description><para><c>vod-media</c>: A media asset in Alibaba Cloud VOD.</para>
        /// </description></item>
        /// <item><description><para><c>S3</c>: A destination that supports the S3 protocol.</para>
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
        /// <para>The ID of the editing project. Call the <a href="https://help.aliyun.com/document_detail/441137.html">CreateEditingProject</a> operation to create an editing project and obtain the <c>ProjectId</c> to submit a media producing job.</para>
        /// <remarks>
        /// <para>Notice: You must specify one of the <c>ProjectId</c>, <c>Timeline</c>, or <c>TemplateId</c> parameters. The other two parameters must be left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxfb2101cb318xxxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The metadata of the editing project, in JSON format. For details about the structure, see <a href="~~357745#title-yvp-81k-wff~~">ProjectMetadata</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Description&quot;:&quot;Video editing description&quot;,&quot;Title&quot;:&quot;Editing title test&quot;}</para>
        /// </summary>
        [NameInMap("ProjectMetadata")]
        [Validation(Required=false)]
        public string ProjectMetadata { get; set; }

        /// <summary>
        /// <para>The source of the media producing job request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>OpenAPI</c>: A request initiated through an API call.</para>
        /// </description></item>
        /// <item><description><para><c>AliyunConsole</c>: A request that originates from the Alibaba Cloud console.</para>
        /// </description></item>
        /// <item><description><para><c>WebSDK</c>: A request sent from a front-end page that integrates the WebSDK.</para>
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
        /// <para>The ID of a template for quickly building a timeline. You can use basic and advanced templates for video editing.</para>
        /// <list type="bullet">
        /// <item><description><para>When you submit a media producing job using a template ID, you must provide the <c>ClipsParam</c> parameter to adjust or replace clips in the template.</para>
        /// </description></item>
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/441164.html">GetTemplate</a> operation to obtain template information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>You must specify one of the <c>ProjectId</c>, <c>Timeline</c>, or <c>TemplateId</c> parameters. The other two parameters must be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The timeline for the cloud editing job. To arrange clips and design effects, manually construct the <c>Timeline</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>A timeline primarily consists of three types of objects: tracks, clips, and effects. For more information, see <a href="https://help.aliyun.com/document_detail/198823.html">Timeline configuration</a>.</para>
        /// </description></item>
        /// <item><description><para>For more examples of timeline configurations, see <a href="https://help.aliyun.com/document_detail/2766669.html">Best practices</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>You must specify one of the <c>ProjectId</c>, <c>Timeline</c>, or <c>TemplateId</c> parameters. The other two parameters must be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>Custom user data in JSON format. The value can be up to 512 bytes in length. This parameter supports <a href="https://help.aliyun.com/document_detail/451631.html">job completion callback configuration</a>. The fields include:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NotifyAddress</c>: The callback for job completion.</para>
        /// </description></item>
        /// <item><description><para><c>RegisterMediaNotifyAddress</c>: The callback invoked when the analysis of the output media asset is complete.</para>
        /// </description></item>
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
