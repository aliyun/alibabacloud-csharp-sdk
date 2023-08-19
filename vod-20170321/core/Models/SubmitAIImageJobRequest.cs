// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageJobRequest : TeaModel {
        /// <summary>
        /// The ID of the pipeline that is used for the AI processing job.
        /// 
        /// <props="china">> This parameter is optional if you have specified a default pipeline ID. If you need to submit image AI processing jobs in a batch to a specific pipeline, [submit a ticket](https://smartservice.console.aliyun.com/service/create-ticket?product=vod) to contact Alibaba Cloud technical support.</props>
        /// <props="intl">> This parameter is optional if you have specified a default pipeline ID. If you need to submit image AI processing jobs in a batch to a specific pipeline, [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.12672711.top-nav.ditem-sub.3cd51fa3WvRsjz#/ticket/add/?productId=1270) to contact Alibaba Cloud technical support.</props>
        /// </summary>
        [NameInMap("AIPipelineId")]
        [Validation(Required=false)]
        public string AIPipelineId { get; set; }

        /// <summary>
        /// The ID of the AI template. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Obtain the value of TemplateId from the response to the [AddAITemplate](~~102930~~) that you call to create the template.
        /// *   Obtain the value of TemplateId from the response to the [ListAITemplate](~~102936~~) operation after you create the template.
        /// </summary>
        [NameInMap("AITemplateId")]
        [Validation(Required=false)]
        public string AITemplateId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// The user data.
        /// 
        /// *   The value must be a JSON string.
        /// *   You must specify the MessageCallback or Extend parameter.
        /// *   The value can contain a maximum of 512 bytes.
        /// 
        /// For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](~~55407~~) operation that you call to upload the video.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](~~86044~~) operation after you upload the video.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
