// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsRequest : TeaModel {
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

        /// <summary>
        /// The type of the advanced configurations. Valid values: online and offline. - online The default value is offline.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
