// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshVodObjectCachesRequest : TeaModel {
        /// <summary>
        /// The URL of the file to be prefetched. Separate multiple URLs with line breaks (\n or \r\n).
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// The type of the object that you want to refresh. Valid values:
        /// 
        /// *   **File** (default): refreshes files.
        /// *   **Directory**: refreshes the files in specified directories.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
