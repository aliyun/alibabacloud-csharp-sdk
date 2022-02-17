// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewDataRequest : TeaModel {
        /// <summary>
        /// 自定义oss域名（可为cdn域名）
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// 是否开启自用资源访问（默认false）
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 预览token
        /// </summary>
        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

        /// <summary>
        /// 是否返回热点数据（默认false）
        /// </summary>
        [NameInMap("ShowTag")]
        [Validation(Required=false)]
        public bool? ShowTag { get; set; }

    }

}
