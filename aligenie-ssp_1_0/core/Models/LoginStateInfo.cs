// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class LoginStateInfo : TeaModel {
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("ThirdUserIdentifier")]
        [Validation(Required=false)]
        public string ThirdUserIdentifier { get; set; }

        [NameInMap("ThirdUserType")]
        [Validation(Required=false)]
        public string ThirdUserType { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
