// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkTemplateFolderTreeResponseBody : TeaModel {
        /// <summary>
        /// The directory structure of Spark applications, which is in the tree format. Fields in the response parameter:
        /// 
        /// *   **Uid**: the UID of the Alibaba Cloud account.
        /// 
        /// *   **Type**: the type of the application template. Valid values: **FOLDER**: directory.
        /// 
        /// *   **Parent**: indicates whether a child directory exists. Valid values:
        /// 
        ///     *   **0**: No child directory exists.
        ///     *   **-1**: A child directory exists.
        /// 
        /// *   **Children**: the child directory.
        /// 
        /// *   **LastModified**: the time when applications in the directory are last modified. The time is displayed in the UNIX timestamp format. Unit: seconds.
        /// 
        /// *   **Name**: the name of the directory.
        /// 
        /// *   **Id**: the ID of the directory.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
