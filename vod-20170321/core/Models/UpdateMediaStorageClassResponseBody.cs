// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the media assets that failed to be processed.
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyForbiddenList ForbiddenList { get; set; }
        public class UpdateMediaStorageClassResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
                /// <summary>
                /// The ID of the media asset.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The reason for the failure.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the media assets that failed to be obtained.
        /// </summary>
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyIgnoredList IgnoredList { get; set; }
        public class UpdateMediaStorageClassResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of the task. Valid values:
        /// 
        /// *   **Processing**
        /// *   **Failed**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
