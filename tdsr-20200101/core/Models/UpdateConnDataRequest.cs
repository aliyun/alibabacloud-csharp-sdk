// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class UpdateConnDataRequest : TeaModel {
        /// <summary>
        /// 场景ID
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// 关联数据
        /// </summary>
        [NameInMap("ConnData")]
        [Validation(Required=false)]
        public string ConnData { get; set; }

    }

}
