// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LineageTable : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<LineageColumn> Columns { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("with")]
        [Validation(Required=false)]
        public Dictionary<string, object> With { get; set; }

    }

}
