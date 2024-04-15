// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksResponseBody : TeaModel {
        /// <summary>
        /// The operation result. If the request was successful, a success message is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Details about the image update task.
        /// </summary>
        [NameInMap("FotaTasks")]
        [Validation(Required=false)]
        public List<DescribeFotaTasksResponseBodyFotaTasks> FotaTasks { get; set; }
        public class DescribeFotaTasksResponseBodyFotaTasks : TeaModel {
            /// <summary>
            /// The version of the image. You can call the [DescribeImages](~~188895~~) operation to obtain this parameter.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// This parameter is not available.
            /// </summary>
            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            /// <summary>
            /// The number of custom images that can be updated to this version.
            /// </summary>
            [NameInMap("PendingCustomImageCount")]
            [Validation(Required=false)]
            public int? PendingCustomImageCount { get; set; }

            /// <summary>
            /// The number of cloud desktops for which images can be updated to this version.
            /// </summary>
            [NameInMap("PendingDesktopCount")]
            [Validation(Required=false)]
            public int? PendingDesktopCount { get; set; }

            /// <summary>
            /// The time when the image version is available for update was published.
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// The description of the image version that is available for update.
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
            /// Indicates whether an end user can update the image.
            /// 
            /// Valid values:
            /// 
            /// *   valid: The end user can update the image.
            /// *   invalid: The end user cannot update the image.
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
        /// The returned error message. This parameter is not returned if the value of Code is `success`.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
