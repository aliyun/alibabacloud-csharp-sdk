// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// The application ID. Default value: **app-1000000**. For more information, see [Use the multi-application service](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the transcoding template group.
        /// 
        /// *   The name can be up to 128 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// > You must specify TranscodeTemplateGroupId or Name in the request.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. If a transcoding template group ID is specified, you can add transcoding templates to the template group.
        /// 
        /// > You must specify TranscodeTemplateGroupId or Name in the request.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// The configurations of the transcoding template. The value is a string in JSON format. For more information about the data structure, see [TranscodeTemplate](https://help.aliyun.com/document_detail/52839.html).
        /// 
        /// > *   If you do not specify this parameter, the transcoding job cannot be automatically created after you upload a video.
        /// > *   If you do not need to set Width or Height, do not specify the corresponding parameter. You cannot set the value to an empty string, such as "Height":"".
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
