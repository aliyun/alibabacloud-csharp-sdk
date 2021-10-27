// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CheckConnectivityRequest : TeaModel {
        [NameInMap("DbInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> DbInfo { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public int? DbType { get; set; }

    }

}
