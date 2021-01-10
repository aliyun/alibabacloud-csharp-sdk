// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmHistorycountRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
