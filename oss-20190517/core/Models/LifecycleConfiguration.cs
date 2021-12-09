// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LifecycleConfiguration : TeaModel {
        /// <summary>
        /// 生命周期规则
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<LifecycleRule> Rule { get; set; }

    }

}
