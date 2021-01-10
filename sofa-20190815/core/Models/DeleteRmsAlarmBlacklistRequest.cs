// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteRmsAlarmBlacklistRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

    }

}
