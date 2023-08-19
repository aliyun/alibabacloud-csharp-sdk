// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// The information about the online editing project. For more information about the structure, see [EditingProject](~~52839~~).
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public AddEditingProjectResponseBodyProject Project { get; set; }
        public class AddEditingProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// The time when the online editing project was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the online editing project.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The last time when the online editing project was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The ID of the online editing project.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// The status of the online editing project. Valid values:
            /// 
            /// - **Normal**: indicates that the online editing project is in draft.
            /// - **Producing**: indicates that the video is being produced.
            /// - **Produced**: indicates that the video was produced.
            /// - **ProduceFailed**: indicates that the video failed to be produced.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The title of the online editing project.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
