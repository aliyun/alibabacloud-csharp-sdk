// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class UpdateLayoutDataRequest : TeaModel {
        /// <summary>
        /// 子场景ID
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

        /// <summary>
        /// 标注数据
        /// </summary>
        [NameInMap("LayoutData")]
        [Validation(Required=false)]
        public string LayoutData { get; set; }

    }

}
