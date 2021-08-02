// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryCopyrightRequest : TeaModel {
        /// <summary>
        /// 创建时间截止
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// 创建时间起始
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 水印强度
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// 翻页下标
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
