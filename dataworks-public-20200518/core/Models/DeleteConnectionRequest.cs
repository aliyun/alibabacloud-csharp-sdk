// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteConnectionRequest : TeaModel {
        /// <summary>
        /// The data source ID. You can call the [ListConnection](https://help.aliyun.com/document_detail/173911.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public long? ConnectionId { get; set; }

    }

}
