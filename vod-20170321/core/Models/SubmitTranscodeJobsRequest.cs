// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// The encryption configurations. The value must be a JSON string. This parameter is required only when you use HLS encryption.
        /// 
        /// > 
        /// 
        /// *   You must set **CipherText** in [EncrptConfig](https://help.aliyun.com/document_detail/86952.html) to the AES_128 cipher text that is obtained from the response to the [GenerateKMSDataKey](https://help.aliyun.com/document_detail/455051.html) operation. Otherwise, the HLS encryption fails. For more information about how to use HLS encryption, see [HLS encryption](https://help.aliyun.com/document_detail/68612.html).
        /// 
        /// *   You must select HLS encryption for the template specified by **TemplateGroupId** no matter you use HLS encryption or Alibaba Cloud proprietary cryptography. Otherwise, the transcoded file is not encrypted.
        /// </summary>
        [NameInMap("EncryptConfig")]
        [Validation(Required=false)]
        public string EncryptConfig { get; set; }

        /// <summary>
        /// The override parameter. The value must be a JSON string. You can use this parameter to override the image watermark, text watermark, or subtitle file specified in the transcoding template, or override the encoding format of the subtitle file. For more information about the data structure, see [OverrideParams](https://help.aliyun.com/document_detail/98618.html).
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// The ID of the queue that you want to use to run the job.
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// The priority of the transcoding job in all queued jobs.
        /// 
        /// *   Valid values: **1** to **10**.
        /// *   A value of **10** indicates the highest priority.
        /// *   Default value: **6**.
        /// 
        /// >  This parameter takes effect only on the queued transcoding jobs. The priorities of the in-progress transcoding jobs are not affected.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// The ID of the transcoding template group that you want to use. To view the template group ID, perform the following operations: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Transcoding Template Groups**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The custom settings. The value must be a JSON string. You can configure settings such as message callbacks. For more information, see [UserData](https://help.aliyun.com/document_detail/86952.html).
        /// 
        /// >  To use the callback configurations specified by this parameter, you must configure an HTTP callback URL and specify the types of the callback events in the ApsaraVideo VOD console. Otherwise, the callback configurations do not take effect.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the video file. You can use one of the following methods to obtain the video ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload the video.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload the video.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
