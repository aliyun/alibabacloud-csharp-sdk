// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksResponseBody : TeaModel {
        /// <summary>
        /// The returned message. If the request was successful, a `success` is returned. If the request failed, an error message is returned.
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
            /// The image version. You can call the [DescribeImages](https://help.aliyun.com/document_detail/188895.html) operation to obtain the value of this parameter.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
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
            /// The number of cloud computers whose images can be updated to this version.
            /// </summary>
            [NameInMap("PendingDesktopCount")]
            [Validation(Required=false)]
            public int? PendingDesktopCount { get; set; }

            /// <summary>
            /// The time when the image version available for update was published.
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// The description of the image version available for update.
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The size of the update package. Unit: KB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// Indicates whether the image update task is automatically pushed.
            /// 
            /// Valid values:
            /// 
            /// *   Running: automatically pushes the image update task.
            /// *   Pending: does not automatically push the image update task.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the image upgrade task.
            /// </summary>
            [NameInMap("TaskUid")]
            [Validation(Required=false)]
            public string TaskUid { get; set; }

        }

        /// <summary>
        /// The returned error message. This parameter is not returned if the Code value is a `success` message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
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
