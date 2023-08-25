// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkTemplateFullTreeResponseBody : TeaModel {
        /// <summary>
        /// The directory structure of the application template. Fields in the response parameter:
        /// 
        /// *   **Uid**: the UID of the Alibaba Cloud account.
        /// 
        /// *   **Type**: the type of the application template. Valid values:
        /// 
        ///     *   **FOLDER**: directory
        ///     *   **FILE**: application
        /// 
        /// *   **Parent**: the parent directory. Valid values:
        /// 
        ///     *   **0**: No child directory exists.
        ///     *   **-1**: A child directory exists.
        /// 
        /// *   **Children**: the child directory.
        /// 
        /// *   **LastModified**: the time when the application is last modified. The time is displayed in the UNIX timestamp format. Unit: seconds.
        /// 
        /// *   **AppType**: the application type. Valid values:
        /// 
        ///     *   **SQL**: SQL application
        ///     *   **STREAMING**: streaming application
        ///     *   **BATCH**: batch application
        /// 
        /// *   **Name**: the name of the directory or application.
        /// 
        /// *   **Id**: the ID of the directory or application.
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
