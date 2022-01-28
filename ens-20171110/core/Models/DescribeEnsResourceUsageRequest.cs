// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageRequest : TeaModel {
        /// <summary>
        /// vm实例使用结束时间查询结束范围，，格式： yyyy-MM-dd或yyyy-MM-dd HH:mm:ss
        /// </summary>
        [NameInMap("ExpiredEndTime")]
        [Validation(Required=false)]
        public string ExpiredEndTime { get; set; }

        /// <summary>
        /// vm实例使用结束时间查询开始范围，格式： yyyy-MM-dd或yyyy-MM-dd HH:mm:ss
        /// </summary>
        [NameInMap("ExpiredStartTime")]
        [Validation(Required=false)]
        public string ExpiredStartTime { get; set; }

    }

}
