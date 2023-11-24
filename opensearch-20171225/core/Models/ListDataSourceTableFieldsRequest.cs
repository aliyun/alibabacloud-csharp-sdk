// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDataSourceTableFieldsRequest : TeaModel {
        /// <summary>
        /// The parameters of the data source. The value of the params parameter is a JSON string. The value must be URL-encoded.
        /// 
        /// Different types of data sources use different parameters. For more information, see the following sections of the "DataSource" topic:
        /// 
        /// *   [rds](~~170005~~)
        /// *   [polardb](~~170005~~)
        /// *   [odps](~~170005~~)
        /// *   [mysql](~~173627~~)
        /// *   [drds](~~173627~~)
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// Whether to return the original field type of the data source
        /// </summary>
        [NameInMap("rawType")]
        [Validation(Required=false)]
        public bool? RawType { get; set; }

    }

}
