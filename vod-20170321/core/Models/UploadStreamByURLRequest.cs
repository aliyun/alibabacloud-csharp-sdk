// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLRequest : TeaModel {
        /// <summary>
        /// The quality of the video stream.
        /// 
        /// For more information about valid values of this parameter, see [Parameters for media assets](~~124671~~).
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The file name extension of the transcoded stream.
        /// 
        /// For more information, see the Supported media file formats section in [Overview](~~55396~~).
        /// 
        /// If you set a value for this parameter, the file name extension specified in StreamURL is overwritten.
        /// 
        /// >  This parameter is required if you do not specify a file name extension in StreamURL.
        /// </summary>
        [NameInMap("FileExtension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// The HDR type of the transcoded stream. Valid values:
        /// 
        /// *   HDR
        /// *   HDR10
        /// *   HLG
        /// *   DolbyVision
        /// *   HDRVivid
        /// *   SDR+
        /// 
        /// > 
        /// 
        /// *   The HDR type of the transcoded stream is not case-sensitive.
        /// 
        /// *   You can leave this parameter empty for non-HDR streams.
        /// </summary>
        [NameInMap("HDRType")]
        [Validation(Required=false)]
        public string HDRType { get; set; }

        /// <summary>
        /// The media ID in ApsaraVideo VOD.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The URL of the transcoded stream.
        /// 
        /// If URL authentication is required, you must pass authentication information in this parameter and make sure that the URL can be accessed over the Internet.
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// The user-defined parameter. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
        /// 
        /// >  The callback configurations you specify for this parameter take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](~~86071~~).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
