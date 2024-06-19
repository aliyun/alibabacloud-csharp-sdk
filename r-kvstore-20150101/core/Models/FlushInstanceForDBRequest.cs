// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class FlushInstanceForDBRequest : TeaModel {
        /// <summary>
        /// The index number of the database. Valid values: 0 to 255.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbIndex")]
        [Validation(Required=false)]
        public int? DbIndex { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
