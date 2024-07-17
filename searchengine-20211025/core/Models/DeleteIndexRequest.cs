// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DeleteIndexRequest : TeaModel {
        /// <summary>
        /// The data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// Specifies whether to delete the data source.
        /// </summary>
        [NameInMap("deleteDataSource")]
        [Validation(Required=false)]
        public bool? DeleteDataSource { get; set; }

    }

}
