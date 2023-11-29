/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DataExtraInfoSubCondsValue : TeaModel {
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("DestDatabase")]
        [Validation(Required=false)]
        public string DestDatabase { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("DestName")]
        [Validation(Required=false)]
        public string DestName { get; set; }

        [NameInMap("WhereClause")]
        [Validation(Required=false)]
        public string WhereClause { get; set; }

        [NameInMap("FilterColumns")]
        [Validation(Required=false)]
        public List<string> FilterColumns { get; set; }

        [NameInMap("ShardColumns")]
        [Validation(Required=false)]
        public List<string> ShardColumns { get; set; }

        [NameInMap("LogicTableId")]
        [Validation(Required=false)]
        public string LogicTableId { get; set; }

        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        [NameInMap("SourceClientId")]
        [Validation(Required=false)]
        public string SourceClientId { get; set; }

    }

}
