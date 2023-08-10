// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DataSource : TeaModel {
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Fields { get; set; }

        [NameInMap("keyField")]
        [Validation(Required=false)]
        public string KeyField { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("plugins")]
        [Validation(Required=false)]
        public Dictionary<string, DataSourcePluginsValue> Plugins { get; set; }

        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
