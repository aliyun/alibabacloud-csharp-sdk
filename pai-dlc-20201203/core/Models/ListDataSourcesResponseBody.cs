// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// 数据源配置列表
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DataSourceItem> DataSources { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 符合条件的数据源总数量
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
