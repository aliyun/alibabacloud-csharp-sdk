// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutAlertSettingListRequest : TeaModel {
        [NameInMap("AlertSettingEditRequestListJson")]
        [Validation(Required=false)]
        public string AlertSettingEditRequestListJson { get; set; }

        [NameInMap("ContactGroupIdsJson")]
        [Validation(Required=false)]
        public string ContactGroupIdsJson { get; set; }

        [NameInMap("ContactIdsJson")]
        [Validation(Required=false)]
        public string ContactIdsJson { get; set; }

    }

}
