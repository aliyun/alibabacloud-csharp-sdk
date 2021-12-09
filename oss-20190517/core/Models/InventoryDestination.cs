// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InventoryDestination : TeaModel {
        /// <summary>
        /// The information about the bucket that stores the exported inventory list
        /// </summary>
        [NameInMap("OSSBucketDestination")]
        [Validation(Required=false)]
        public InventoryOSSBucketDestination OSSBucketDestination { get; set; }

    }

}
