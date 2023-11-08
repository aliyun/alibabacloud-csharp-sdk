// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateFormDataRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("FormInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("UpdateFormDataJson")]
        [Validation(Required=false)]
        public string UpdateFormDataJson { get; set; }

        [NameInMap("UseLatestVersion")]
        [Validation(Required=false)]
        public bool? UseLatestVersion { get; set; }

    }

}
