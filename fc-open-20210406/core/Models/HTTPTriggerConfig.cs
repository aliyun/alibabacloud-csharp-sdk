// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class HTTPTriggerConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// 禁用默认公网域名访问的开关，设置为true 时，访问函数默认提供的公网URL地址会返回403错误。设置为 false 则不会有任何影响。
        /// </summary>
        [NameInMap("disableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

    }

}
