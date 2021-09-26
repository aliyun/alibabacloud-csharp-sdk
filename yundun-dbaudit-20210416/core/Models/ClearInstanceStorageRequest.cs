/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20210416.Models
{
    public class ClearInstanceStorageRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public string StorageSpace { get; set; }

        [NameInMap("StorageCategory")]
        [Validation(Required=false)]
        public string StorageCategory { get; set; }

    }

}
