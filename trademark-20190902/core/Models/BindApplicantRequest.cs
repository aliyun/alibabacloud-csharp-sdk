/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class BindApplicantRequest : TeaModel {
        [NameInMap("ApplicantId")]
        [Validation(Required=false)]
        public string ApplicantId { get; set; }

        [NameInMap("AuthorizationOssKey")]
        [Validation(Required=false)]
        public string AuthorizationOssKey { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

    }

}
