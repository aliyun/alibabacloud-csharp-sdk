// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLResponseBody : TeaModel {
        /// <summary>
        /// The URL of the OSS object.
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URL of the input stream. This parameter is used when you call the [GetURLUploadInfos](~~106830~~) operation.
        /// </summary>
        [NameInMap("SourceURL")]
        [Validation(Required=false)]
        public string SourceURL { get; set; }

        /// <summary>
        /// The ID of the stream upload job. This parameter is used when you call the [GetURLUploadInfos](~~106830~~) operation.
        /// 
        /// In ApsaraVideo VOD, you can upload only one transcoded stream in an upload job. For more information, see the PlayInfo: the playback information about a video stream section in [Basic structures](~~52839~~).
        /// </summary>
        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

    }

}
