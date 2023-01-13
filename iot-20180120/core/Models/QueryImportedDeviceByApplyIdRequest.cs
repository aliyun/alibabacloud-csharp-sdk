// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryImportedDeviceByApplyIdRequest : TeaModel {
        [NameInMap("ApplyId")]
        [Validation(Required=true)]
        public long? ApplyId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=true)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

    }

}
