// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryDWSMetadataTablesRequest : TeaModel {
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LogicTableArn")]
        [Validation(Required=false)]
        public string LogicTableArn { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
