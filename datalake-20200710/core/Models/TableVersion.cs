// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class TableVersion : TeaModel {
        [NameInMap("Table")]
        [Validation(Required=false)]
        public Table Table { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public int? VersionId { get; set; }

    }

}
