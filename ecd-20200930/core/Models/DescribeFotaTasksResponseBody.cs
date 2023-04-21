// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksResponseBody : TeaModel {
        /// <summary>
        /// Details about the image update tasks.
        /// </summary>
        [NameInMap("FotaTasks")]
        [Validation(Required=false)]
        public List<DescribeFotaTasksResponseBodyFotaTasks> FotaTasks { get; set; }
        public class DescribeFotaTasksResponseBodyFotaTasks : TeaModel {
            /// <summary>
            /// The version of the custom image. You can call the [DescribeImages](~~188895~~) operation to obtain the value of this parameter.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// This parameter is not available to the public.
            /// </summary>
            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            [NameInMap("PendingCustomImageCount")]
            [Validation(Required=false)]
            public int? PendingCustomImageCount { get; set; }

            /// <summary>
            /// The number of cloud desktops for which the images can be updated to this version.
            /// </summary>
            [NameInMap("PendingDesktopCount")]
            [Validation(Required=false)]
            public int? PendingDesktopCount { get; set; }

            /// <summary>
            /// The time when the updated image was published.
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// The description of the image version to which the original image is updated.
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The size of the image update package. Unit: KB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// Indicates whether the user can update the image of the cloud desktop.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the image update task.
            /// </summary>
            [NameInMap("TaskUid")]
            [Validation(Required=false)]
            public string TaskUid { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
