// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurSummaryOverviewRequest : TeaModel {
        /// <summary>
        /// 当前时间戳
        /// </summary>
        [NameInMap("CurTs")]
        [Validation(Required=false)]
        public long? CurTs { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
