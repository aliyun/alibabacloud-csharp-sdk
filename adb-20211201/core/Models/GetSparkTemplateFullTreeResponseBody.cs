// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkTemplateFullTreeResponseBody : TeaModel {
        /// <summary>
        /// The directory structure of Spark applications. Fields in the response parameter:
        /// 
        /// *   **Uid**: the UID of the Alibaba Cloud account.
        /// 
        /// *   **Type**: the application template type. Valid values:
        /// 
        ///     *   **FOLDER**
        ///     *   **FILE**
        /// 
        /// *   **Parent**: indicates whether a child directory exists. Valid values:
        /// 
        ///     *   **0**: no.
        ///     *   **-1**: yes.
        /// 
        /// *   **Children**: the child directory.
        /// 
        /// *   **LastModified**: the time when applications are last modified. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// *   **AppType**: the application type. Valid values:
        /// 
        ///     *   **SQL**
        ///     *   **STREAMING**
        ///     *   **BATCH**
        /// 
        /// *   **Name**: the name of the directory or application.
        /// 
        /// *   **Id**: the directory ID or application ID.
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
