// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateDownloadTaskRequest : TeaModel {
        /// <summary>
        /// The language of the content within the response.
        /// 
        /// Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The query condition of the download task.
        /// </summary>
        [NameInMap("TaskData")]
        [Validation(Required=false)]
        public string TaskData { get; set; }

        /// <summary>
        /// The time zone of the time information in the downloaded file. The value must be an identifier of a time zone in the Internet Assigned Numbers Authority (IANA) database. The default value is Asia/Shanghai, which indicates UTC+8.
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
