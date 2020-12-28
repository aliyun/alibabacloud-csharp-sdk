// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchBodyTraceShrinkRequest : TeaModel {
        /// <summary>
        /// 数据库ID
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// Trace图片信息列表
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string ImagesShrink { get; set; }

        /// <summary>
        /// 结果Trace数量上限，默认10，取值范围[1, 100]
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// score阈值，只返回大于等于该score的数据，取值范围[-1.0, 1.0]，默认为空
        /// </summary>
        [NameInMap("MinScore")]
        [Validation(Required=false)]
        public float? MinScore { get; set; }

    }

}
