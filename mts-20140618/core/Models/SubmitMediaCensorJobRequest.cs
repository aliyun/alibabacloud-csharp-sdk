// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        /// <summary>
        /// <para>The live comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello world</para>
        /// </summary>
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        /// <summary>
        /// <para>The OSS URL of the image file that is used as the thumbnail. To view the OSS URL of the image file, you can log on to the <b>MPS console</b> and choose <b>Media Management</b> &gt; <b>Media List</b> in the left-side navigation pane. You can specify up to five thumbnails in a JSON array.</para>
        /// <list type="bullet">
        /// <item><description><para>Bucket: the name of the OSS bucket that stores the input file.</para>
        /// </description></item>
        /// <item><description><para>Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.</para>
        /// </description></item>
        /// <item><description><para>Object: the OSS object to be moderated.</para>
        /// <para>**</para>
        /// <para><b>Note</b>The name of the object cannot start with a forward slash (/). Otherwise, the operation fails to be called.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.jpeg&quot;}]</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        /// <summary>
        /// <para>The description of the video. The value can be up to 128 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The URL of the video.</para>
        /// </summary>
        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URL of the media file to be moderated. To view the OSS URL of the media file, you can log on to the <b>MPS console</b> and choose <b>Media Management</b> &gt; <b>Media List</b> in the left-side navigation pane. To moderate an image file, use the <c>CoverImage</c> parameter to specify the OSS URL of the image file. The value is a JSON object. For more information, see the &quot;Input&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// <list type="bullet">
        /// <item><description><para>Bucket: the name of the OSS bucket that stores the input file.</para>
        /// </description></item>
        /// <item><description><para>Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.</para>
        /// </description></item>
        /// <item><description><para>Object: the OSS object to be moderated.</para>
        /// <para>**</para>
        /// <para><b>Note</b>The name of the object cannot start with a forward slash (/). Otherwise, the operation fails to be called.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.flv&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue. This ID can be used to associate the job with a notification method. To view the ID of the MPS queue, you can log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane. An empty string (&quot;&quot;) indicates that the default MPS queue is used to run the job. By default, an MPS queue can process a maximum of 10 concurrent content moderation jobs. To increase the limit, <a href="https://workorder-intl.console.aliyun.com/?spm=5176.12246746.top-nav.ditem-sub.35da7bbcitpQnr#/ticket/createIndex">submit a ticket</a>.</para>
        /// <remarks>
        /// <para>MPS queues are automatically created by the system. For more information about how to query and update MPS queues, see the <a href="https://help.aliyun.com/document_detail/188374.html">UpdatePipeline</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b22c173cced04565b1f38f1ecc39****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The title of the video. The value can be up to 64 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello World</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom data. The value can be up to 128 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserDatatestid-001-****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The video moderation configurations and the OSS URLs of the output snapshots. To view the OSS URL of the media file, you can log on to the <b>MPS console</b> and choose <b>Media Management</b> &gt; <b>Media List</b> in the left-side navigation pane.</para>
        /// <para>The value is a JSON object.</para>
        /// <list type="bullet">
        /// <item><description><para>OutputFile:</para>
        /// <list type="bullet">
        /// <item><description>Bucket: the name of the OSS bucket that stores the output file.</description></item>
        /// <item><description>Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.</description></item>
        /// <item><description>Object: the OSS object to be generated. In the value, {Count} indicates the sequence number of the frame snapshot.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>StoreVideoTimeline: specifies whether to generate the <c>{jobId}.video_timeline</c> file. The file is stored in OSS. A value of true indicates that the file is generated. A value of false indicates that the file is not generated. If you do not specify this parameter, the file is not generated by default. For more information about the format of the file, see the &quot;VideoTimelines&quot; parameter in the <a href="https://help.aliyun.com/document_detail/91779.html">QueryMediaCensorJobDetail</a> topic.</para>
        /// </description></item>
        /// <item><description><para>SaveType: the output mode. A value of abnormal indicates that snapshots are generated only for illegal frames. A value of all indicates that snapshots are generated for all frames.</para>
        /// </description></item>
        /// <item><description><para>Biztype: the moderation template. If you do not specify this parameter or set the value to common, the default template is used. You can submit a ticket to create a custom moderation template. Then, set this parameter to your user ID to use the custom moderation template.</para>
        /// </description></item>
        /// <item><description><para>Scenes: the moderation scenarios. You can specify the moderation scenarios that you want to use. If you do not specify this parameter, the terrorism and porn moderation scenarios are used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>porn: pornographic content detection</description></item>
        /// <item><description>terrorism: terrorist content detection</description></item>
        /// <item><description>ad: ad violation detection</description></item>
        /// <item><description>live: undesirable scene detection</description></item>
        /// <item><description>logo: special logo detection</description></item>
        /// <item><description>audio: audio anti-spam</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the input file contains audio tracks and the audio moderation scenario is specified, the audio tracks are moderated. If the input file does not contain audio tracks, you do not need to specify the audio moderation scenario.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Scenes&quot; : [&quot;porn&quot;], &quot;OutputFile&quot;:{&quot;Bucket&quot;: &quot;example-001&quot;,&quot;Location&quot;: &quot;oss-cn-hangzhou&quot;,&quot;Object&quot;: &quot;test/example-{Count}.jpg&quot;},&quot;SaveType&quot; : &quot;abnormal&quot;,&quot;BizType&quot;:&quot;common&quot;}</para>
        /// </summary>
        [NameInMap("VideoCensorConfig")]
        [Validation(Required=false)]
        public string VideoCensorConfig { get; set; }

    }

}
