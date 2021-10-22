// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class BindInterconnectionUidShrinkRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 绑定用户请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public string RequestParamsShrink { get; set; }

    }

}
