// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayIsolationRuleRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// just for POP
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public string FilterParams { get; set; }

    }

}
