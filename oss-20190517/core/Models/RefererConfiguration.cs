// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RefererConfiguration : TeaModel {
        /// <summary>
        /// 是否允许Referer字段为空的请求访问
        /// </summary>
        [NameInMap("AllowEmptyReferer")]
        [Validation(Required=false)]
        public bool? AllowEmptyReferer { get; set; }

        /// <summary>
        /// 保存Referer访问白名单
        /// </summary>
        [NameInMap("RefererList")]
        [Validation(Required=false)]
        public RefererConfigurationRefererList RefererList { get; set; }
        public class RefererConfigurationRefererList : TeaModel {
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }
        };

    }

}
