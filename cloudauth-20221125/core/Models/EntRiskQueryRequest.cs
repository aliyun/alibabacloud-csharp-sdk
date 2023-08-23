// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryRequest : TeaModel {
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        [NameInMap("ParamValue")]
        [Validation(Required=false)]
        public string ParamValue { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
