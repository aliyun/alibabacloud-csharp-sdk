// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the transcoding template group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The lock status of the transcoding template group. Valid values:
        /// 
        /// *   **Disabled**: The template group is not locked.
        /// *   **Enabled**: The template group is locked.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupList")]
        [Validation(Required=false)]
        public List<ListTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupList> TranscodeTemplateGroupList { get; set; }
        public class ListTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupList : TeaModel {
            /// <summary>
            /// The operation that you want to perform. Set the value to **ListTranscodeTemplateGroup**.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the template group was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// Queries transcoding template groups.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

        }

    }

}
