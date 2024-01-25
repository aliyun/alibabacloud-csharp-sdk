// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class CheckDataSourceLinkConnectionRequest : TeaModel {
        [NameInMap("DataSourceParams")]
        [Validation(Required=false)]
        public string DataSourceParams { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public int? DataSourceType { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
