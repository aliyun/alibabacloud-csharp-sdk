// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        /// <summary>
        /// The live comments.
        /// </summary>
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        /// <summary>
        /// The OSS URL of the image file that is used as the thumbnail. To view the OSS URL of the image file, you can log on to the **MPS console** and choose **Media Management** > **Media List** in the left-side navigation pane. You can specify up to five thumbnails in a JSON array.
        /// 
        /// *   Bucket: the name of the OSS bucket that stores the input file.
        /// 
        /// *   Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.
        /// 
        /// *   Object: the OSS object to be moderated.
        /// 
        ///     **
        /// 
        ///     **Note**The name of the object cannot start with a forward slash (/). Otherwise, the operation fails to be called.
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        /// <summary>
        /// The description of the video. The value can be up to 128 bytes in size.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The URL of the video.
        /// </summary>
        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) URL of the media file to be moderated. To view the OSS URL of the media file, you can log on to the **MPS console** and choose **Media Management** > **Media List** in the left-side navigation pane. To moderate an image file, use the `CoverImage` parameter to specify the OSS URL of the image file. The value is a JSON object. For more information, see the "Input" section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
        /// 
        /// *   Bucket: the name of the OSS bucket that stores the input file.
        /// 
        /// *   Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.
        /// 
        /// *   Object: the OSS object to be moderated.
        /// 
        ///     **
        /// 
        ///     **Note**The name of the object cannot start with a forward slash (/). Otherwise, the operation fails to be called.
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
        /// The ID of the MPS queue. This ID can be used to associate the job with a notification method. To view the ID of the MPS queue, you can log on to the **MPS console** and choose **Global Settings** > **Pipelines** in the left-side navigation pane. An empty string ("") indicates that the default MPS queue is used to run the job. By default, an MPS queue can process a maximum of 10 concurrent content moderation jobs. To increase the limit, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.12246746.top-nav.ditem-sub.35da7bbcitpQnr#/ticket/createIndex).
        /// 
        /// > MPS queues are automatically created by the system. For more information about how to query and update MPS queues, see the [UpdatePipeline](https://help.aliyun.com/document_detail/188374.html) topic.
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
        /// The title of the video. The value can be up to 64 bytes in size.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom data. The value can be up to 128 bytes in size.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The video moderation configurations and the OSS URLs of the output snapshots. To view the OSS URL of the media file, you can log on to the **MPS console** and choose **Media Management** > **Media List** in the left-side navigation pane.
        /// 
        /// The value is a JSON object.
        /// 
        /// *   OutputFile:
        /// 
        ///     *   Bucket: the name of the OSS bucket that stores the output file.
        ///     *   Location: the OSS region. The OSS region must be the same as the region in which your MPS service is activated.
        ///     *   Object: the OSS object to be generated. In the value, {Count} indicates the sequence number of the frame snapshot.
        /// 
        /// *   StoreVideoTimeline: specifies whether to generate the `{jobId}.video_timeline` file. The file is stored in OSS. A value of true indicates that the file is generated. A value of false indicates that the file is not generated. If you do not specify this parameter, the file is not generated by default. For more information about the format of the file, see the "VideoTimelines" parameter in the [QueryMediaCensorJobDetail](https://help.aliyun.com/document_detail/91779.html) topic.
        /// 
        /// *   SaveType: the output mode. A value of abnormal indicates that snapshots are generated only for illegal frames. A value of all indicates that snapshots are generated for all frames.
        /// 
        /// *   Biztype: the moderation template. If you do not specify this parameter or set the value to common, the default template is used. You can submit a ticket to create a custom moderation template. Then, set this parameter to your user ID to use the custom moderation template.
        /// 
        /// *   Scenes: the moderation scenarios. You can specify the moderation scenarios that you want to use. If you do not specify this parameter, the terrorism and porn moderation scenarios are used by default. Valid values:
        /// 
        ///     *   porn: pornographic content detection
        ///     *   terrorism: terrorist content detection
        ///     *   ad: ad violation detection
        ///     *   live: undesirable scene detection
        ///     *   logo: special logo detection
        ///     *   audio: audio anti-spam
        /// 
        /// > If the input file contains audio tracks and the audio moderation scenario is specified, the audio tracks are moderated. If the input file does not contain audio tracks, you do not need to specify the audio moderation scenario.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoCensorConfig")]
        [Validation(Required=false)]
        public string VideoCensorConfig { get; set; }

    }

}
