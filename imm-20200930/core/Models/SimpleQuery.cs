/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQuery : TeaModel {
        /// <summary>
        /// 需要查询的字段名
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// 需要查询的字段值
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// 由 SimpleQuery 结构体组成的子查询数组
        /// </summary>
        [NameInMap("SubQueries")]
        [Validation(Required=false)]
        public List<SimpleQuery> SubQueries { get; set; }

    }

}
