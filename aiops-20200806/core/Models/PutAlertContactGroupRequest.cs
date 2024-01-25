// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutAlertContactGroupRequest : TeaModel {
        [NameInMap("AlertContactGroupJson")]
        [Validation(Required=false)]
        public string AlertContactGroupJson { get; set; }

        [NameInMap("ContactIdsJson")]
        [Validation(Required=false)]
        public string ContactIdsJson { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
