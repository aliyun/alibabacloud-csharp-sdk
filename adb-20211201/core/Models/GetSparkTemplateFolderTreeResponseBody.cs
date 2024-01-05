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
        /// *   **Type**: the application template type. Valid values: **FOLDER**
        /// 
        /// *   **Parent**: indicates whether a child directory exists. Valid values:
        /// 
        ///     *   **0**: no.
        ///     *   **-1**: yes.
        /// 
        /// *   **Children**: the child directory.
        /// 
        /// *   **LastModified**: the time when applications in the directory are last modified. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// *   **Name**: the name of the directory.
        /// 
        /// *   **Id**: the directory ID.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
