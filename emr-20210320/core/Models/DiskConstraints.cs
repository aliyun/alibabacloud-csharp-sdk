// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DiskConstraints : TeaModel {
        /// <summary>
        /// 支持的磁盘类型。
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 磁盘数量最小值。
        /// </summary>
        [NameInMap("CountConstraint")]
        [Validation(Required=false)]
        public ValueConstraints CountConstraint { get; set; }

        /// <summary>
        /// 磁盘容量限制。
        /// </summary>
        [NameInMap("SizeConstraint")]
        [Validation(Required=false)]
        public ValueConstraints SizeConstraint { get; set; }

    }

}
