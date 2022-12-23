// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the entire transcoding template group. Valid values:
        /// 
        /// *   **true**: deletes the entire transcoding template group and its transcoding templates.
        /// *   **false**: removes the specified transcoding templates from the transcoding template group. This is the default value.
        /// </summary>
        [NameInMap("ForceDelGroup")]
        [Validation(Required=false)]
        public string ForceDelGroup { get; set; }

        /// <summary>
        /// The ID of the transcoding template group.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// The IDs of the transcoding templates that you want to remove.
        /// 
        /// *   Separate multiple IDs with commas (,).
        /// *   You can specify a maximum of 10 IDs.
        /// </summary>
        [NameInMap("TranscodeTemplateIds")]
        [Validation(Required=false)]
        public string TranscodeTemplateIds { get; set; }

    }

}
