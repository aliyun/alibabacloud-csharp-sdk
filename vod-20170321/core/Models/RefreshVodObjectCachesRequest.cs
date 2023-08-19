// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshVodObjectCachesRequest : TeaModel {
        /// <summary>
        /// The path of the resource to be refreshed. Separate multiple paths with line breaks (\n or \r\n).
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// The granularity of the resources to be refreshed. Valid values:
        /// 
        /// *   **File**: refreshes one or more files. This is the default value.
        /// *   **Directory**: refreshes the files under one or more directories.
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
