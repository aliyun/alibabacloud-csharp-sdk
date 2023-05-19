// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dop20221130.Models
{
    public class GetOssMetaListRequest : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
