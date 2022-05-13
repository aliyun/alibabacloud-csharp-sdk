// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class RestartSeataServerRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("SeataServerUniqueId")]
        [Validation(Required=false)]
        public string SeataServerUniqueId { get; set; }

    }

}
