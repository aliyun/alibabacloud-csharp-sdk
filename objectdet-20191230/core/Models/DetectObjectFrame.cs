// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectObjectFrame : TeaModel {
        /// <summary>
        /// 结果集
        /// </summary>
        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<DetectObjectElement> Elements { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
