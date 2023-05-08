// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionHistoryRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The name of the alert.
        /// </summary>
        [NameInMap("HistoryName")]
        [Validation(Required=false)]
        public string HistoryName { get; set; }

        /// <summary>
        /// The types of exceptions.
        /// </summary>
        [NameInMap("InterceptionTypes")]
        [Validation(Required=false)]
        public List<int?> InterceptionTypes { get; set; }

        /// <summary>
        /// 设置请求和接收消息的语言类型。默认值**zh**。取值：
        /// 
        /// 
        /// - **zh**：中文
        /// - **en**：英文
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The start of the time range to query. The value is a UNIX timestamp.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
