// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class GetMainPartListRequest : TeaModel {
        /// <summary>
        /// 业务类型，见接口文档枚举
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// 主体名称，mainName
        /// </summary>
        [NameInMap("MainName")]
        [Validation(Required=false)]
        public string MainName { get; set; }

        /// <summary>
        /// 主体类型：0代理商1直投2被代理品牌	1
        /// </summary>
        [NameInMap("MainType")]
        [Validation(Required=false)]
        public int? MainType { get; set; }

        /// <summary>
        /// 分页参数：页码 从1开始
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 分页参数，每页大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 代理商主体ID
        /// </summary>
        [NameInMap("ParentMainId")]
        [Validation(Required=false)]
        public long? ParentMainId { get; set; }

    }

}
