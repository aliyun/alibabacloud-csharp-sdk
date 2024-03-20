// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DeleteIndexRequest : TeaModel {
        /// <summary>
        /// The data source
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        [NameInMap("deleteDataSource")]
        [Validation(Required=false)]
        public bool? DeleteDataSource { get; set; }

    }

}
