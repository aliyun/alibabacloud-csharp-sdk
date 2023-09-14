// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ValueConstraints : TeaModel {
        /// <summary>
        /// 默认值。
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public int? DefaultValue { get; set; }

        /// <summary>
        /// 结束值。
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public int? End { get; set; }

        /// <summary>
        /// 起始值。
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        /// <summary>
        /// 步长。
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public int? Step { get; set; }

        /// <summary>
        /// 值限制类型。
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 枚举值。
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<int?> Values { get; set; }

    }

}
