// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the transcoding template group. Valid values:
        /// 
        /// *   **true**: deletes the transcoding template group and all the transcoding templates in the group.
        /// *   **false** (default): deletes only the specified transcoding templates from the transcoding template group.
        /// </summary>
        [NameInMap("ForceDelGroup")]
        [Validation(Required=false)]
        public string ForceDelGroup { get; set; }

        /// <summary>
        /// The ID of the transcoding template group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// The IDs of the transcoding templates that you want to delete.
        /// 
        /// *   Separate multiple IDs with commas (,).
        /// *   You can specify a maximum of 10 IDs.
        /// *   This parameter is required if you set ForceDelGroup to false or leave ForceDelGroup empty.
        /// </summary>
        [NameInMap("TranscodeTemplateIds")]
        [Validation(Required=false)]
        public string TranscodeTemplateIds { get; set; }

    }

}
