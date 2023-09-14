// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DeploymentSetConstraints : TeaModel {
        /// <summary>
        /// 默认值。
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("EnableState")]
        [Validation(Required=false)]
        public string EnableState { get; set; }

        /// <summary>
        /// 替换策略。
        /// </summary>
        [NameInMap("ReplacementStrategy")]
        [Validation(Required=false)]
        public ReplacementStrategy ReplacementStrategy { get; set; }

        /// <summary>
        /// 枚举值。
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
