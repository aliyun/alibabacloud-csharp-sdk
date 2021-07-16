// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemSubtotalRequest : TeaModel {
        /// <summary>
        /// 故障Id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 小计文本
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
