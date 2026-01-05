// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAppIcpRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>app-icp备案实体id列表</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppIcpRecordIdList")]
        [Validation(Required=false)]
        public string AppIcpRecordIdListShrink { get; set; }

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
