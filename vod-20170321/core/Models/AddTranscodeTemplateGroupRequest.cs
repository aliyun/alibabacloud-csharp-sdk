// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the transcoding template group.
        /// 
        /// - The name can be up to 128 bytes in length.
        /// - The value must be encoded in UTF-8.
        /// 
        /// > You must set TranscodeTemplateGroupId or Name in the request.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. If a transcoding template group ID is specified, you can add new transcoding templates to the template group.
        /// 
        /// > You must set TranscodeTemplateGroupId or Name in the request.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// The configurations of the transcoding template. The value is a string in JSON format. For more information about the data structure, see [Basic structures](~~52839~~).
        /// 
        /// > If you do not specify this parameter, the transcoding job cannot be automatically created after you upload a video.
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
