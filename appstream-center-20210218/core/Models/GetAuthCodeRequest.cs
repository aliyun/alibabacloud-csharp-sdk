/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetAuthCodeRequest : TeaModel {
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
