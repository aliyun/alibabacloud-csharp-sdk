// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewInfoRequest : TeaModel {
        /// <summary>
        /// 自定义oss域名（可为cdn域名）
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// 是否开启自用资源访问
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 模型token
        /// </summary>
        [NameInMap("ModelToken")]
        [Validation(Required=false)]
        public string ModelToken { get; set; }

    }

}
