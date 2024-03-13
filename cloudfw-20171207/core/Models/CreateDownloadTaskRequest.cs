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

    }

}
