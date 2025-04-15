// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvBaseTableDetailModel : TeaModel {
        [NameInMap("DataVolumn")]
        [Validation(Required=false)]
        public string DataVolumn { get; set; }

        [NameInMap("EnableBinlog")]
        [Validation(Required=false)]
        public bool? EnableBinlog { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
