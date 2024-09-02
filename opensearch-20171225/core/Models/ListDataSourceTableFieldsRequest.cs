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
        /// *   [rds](https://help.aliyun.com/document_detail/170005.html)
        /// *   [polardb](https://help.aliyun.com/document_detail/170005.html)
        /// *   [odps](https://help.aliyun.com/document_detail/170005.html)
        /// *   [mysql](https://help.aliyun.com/document_detail/173627.html)
        /// *   [drds](https://help.aliyun.com/document_detail/173627.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// Specifies whether to return the original field types of the data source.
        /// </summary>
        [NameInMap("rawType")]
        [Validation(Required=false)]
        public bool? RawType { get; set; }

    }

}
