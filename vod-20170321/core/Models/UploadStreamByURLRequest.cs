// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLRequest : TeaModel {
        /// <summary>
        /// The media ID in ApsaraVideo VOD.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The quality of the video stream.
        /// 
        /// For more information about valid values of this parameter, see [Parameters for media assets](~~124671~~).
        /// </summary>
        [NameInMap("FileExtension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// The file name extension of the transcoded stream.
        /// 
        /// For more information, see the Supported media file formats section in [Overview](~~55396~~).
        /// 
        /// If you set a value for this parameter, the file name extension specified in StreamURL is overwritten.
        /// 
        /// >  This parameter is required if you do not specify a file name extension in StreamURL.
        /// </summary>
        [NameInMap("HDRType")]
        [Validation(Required=false)]
        public string HDRType { get; set; }

        /// <summary>
        /// The URL of the OSS object.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The basic information.
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
