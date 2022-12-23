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
        /// The metadata of the produced video, in JSON format. For more information about the structure, see [MediaMetadata](~~52839~~).
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The configuration of video production, in JSON format. For more information about the structure, see [ProduceConfig](~~52839~~).
        /// </summary>
        [NameInMap("ProduceConfig")]
        [Validation(Required=false)]
        public string ProduceConfig { get; set; }

        /// <summary>
        /// The ID of the online editing project.
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
        /// The timeline of the online editing project, in JSON format. For more information about the structure, see [Timeline](~~52839~~).
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
        /// The custom configuration, such as the callback configuration. The value is a JSON-formatted string. For more information about the structure, see [UserData](~~86952~~).
        /// 
        /// > To use the MessageCallback parameter, you must set an HTTP callback URL and select a callback event type in the ApsaraVideo VOD console. Otherwise, the callback configuration does not take effect.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
