// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// The ID of the frame animation template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DynamicImageTemplateId")]
        [Validation(Required=false)]
        public string DynamicImageTemplateId { get; set; }

        /// <summary>
        /// The override parameter. Specify the value in the JSON format. For more information, see [Parameters for media processing](https://help.aliyun.com/document_detail/98618.html). You can use this parameter to override configurations in the animated image template. For more information, see the "DynamicImageTemplateConfig: the configurations of an animated sticker template" section of the [Basic data types](https://help.aliyun.com/document_detail/52839.html) topic.
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the media file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload media files.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload media files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
