// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoRequest : TeaModel {
        /// <summary>
        /// The thumbnail URL of the online editing project.
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the online editing project.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The video metadata. The value must be in JSON format. For more information about the parameter structure, see [MediaMetadata](~~52839#title_rtf_ry5\_gjp~~).
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The configuration of video production. The value must be in JSON format. For more information about the parameter structure, see [ProduceConfig](~~52839#title_ybl\_7cs_y7d~~).
        /// 
        /// > The StorageLocation field is required if you create an online editing project in a region other than the China (Shanghai) region.
        /// </summary>
        [NameInMap("ProduceConfig")]
        [Validation(Required=false)]
        public string ProduceConfig { get; set; }

        /// <summary>
        /// The ID of the online editing project. You can use one of the following methods to obtain the ID of the online editing project:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Production Center** > **Video Editing** to view the ID of the online editing project.
        /// *   Obtain the value of ProjectId from the response to the [AddEditingProject](~~69048~~) operation.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The timeline of the online editing project. The value must be in JSON format. For more information about the parameter structure, see [Timeline](~~52839#07bc7fe0f2xuh~~).
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// The title of the online editing project.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations, such as the callback configuration. The value must be a JSON string. For more information about the parameter structure, see [UserData](~~86952#title_vz7\_xzs\_0c5~~).
        /// 
        /// > The callback configurations take effect only after you specify an HTTP URL for receiving callback notifications and select the event types in the ApsaraVideo VOD console.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
