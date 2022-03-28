/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class DemoCategory : TeaModel {
        /// <summary>
        /// 目录码
        /// </summary>
        [NameInMap("CategoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 目录名
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// 目录列表
        /// </summary>
        [NameInMap("SubCategories")]
        [Validation(Required=false)]
        public List<DemoCategory> SubCategories { get; set; }

    }

}
